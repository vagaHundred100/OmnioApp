using AutoMapper;
using BLL.Autorization.Abstract;
using BLL.Autorization.Concrete;
using BLL.Domains;
using BLL.DTO;
using BLL.Services.Abstract;
using DAL.Context;
using DAL.Domains;
using DAL.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concrete
{
    public class AccauntService : IAccauntService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IJWTTokenService _tokenService;
        private readonly JWTOptions _jwtSettings;
        private readonly IMapper _mapper;

        public AccauntService(IJWTTokenService tokenService,
                              IOptionsSnapshot<JWTOptions> jwtSettings,
                              IMapper mapper,
                              UserManager<User> userRepository,
                              RoleManager<IdentityRole> roleManager, 
                              IUserRoleRepository userRoleRepository)
        {
            _tokenService = tokenService;
            _jwtSettings = jwtSettings.Value;
            _mapper = mapper;
            _userManager = userRepository;
            _roleManager = roleManager;
            _userRoleRepository = userRoleRepository;
        }

        public async Task<ServiceResponce> ActivateUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponse(new List<string>
                                                   {"User with such name does not exist" }, code);
            }

            user.IsEnabled = true;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.Forbidden;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }
            return new ServiceResponce();
        }

        public async Task<ServiceResponce> DeactivateUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponse(new List<string>
                                                   {"User with such name does not exist" }, code);
            }

            user.IsEnabled = false;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.Forbidden;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();
        }

        public async Task<ServiceResponce> ChangePasswordAsync(ChangePasswordDTO model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponse(new List<string>
                                                   {"User with such name does not exist" }, code);
            }

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPass, model.NewPass);
            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.Forbidden;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();
        }

        public async Task<ServiceResponce> ResetPasswordAsync(RisetPasswordDTO model)
        {
            var user = await _userManager.FindByNameAsync(model.UserId);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponse(new List<string>
                                                   {"User with such name does not exist" }, code);
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPass);

            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.Forbidden;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();
        }

        public ServiceResponceWithData<List<User>> GetAllUsersAsync()
        {
            var response = new ServiceResponceWithData<List<User>>();
            response.Data = _userManager.Users.ToList();
            return response;
        }

        public async Task<ServiceResponceWithData<string>> LoginAsync(LoginDTO model)
        {
            var response = new ServiceResponceWithData<string>();

            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponseWithData<string>(new List<string>
                                                           {"Wrong id" }, code);
            }

            var isCorrect = await _userManager.CheckPasswordAsync(user, model.Password);

            if (!isCorrect)
            {
                var code = (int)HttpStatusCode.Forbidden;
                return CreateUnsuccessifullResponseWithData<string>(new List<string> { "Wrong password" }, code);
            }

            var options = _mapper.Map<UserClaimsOptions>(user);
            var roles = await _userManager.GetRolesAsync(user);
            var token = _tokenService.GenerateJwt(options, roles, _jwtSettings);
            response.Data = token;
            return response;
        }

        public async Task<ServiceResponce> RegisterAsync(RegisterDTO model)
        {
            var user = _mapper.Map<User>(model);
            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                var code = (int)HttpStatusCode.Conflict;
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();
        }

        public async Task<ServiceResponce> AddUserToRoleAsync(string id, string role)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponse(new List<string>
                                                   {"User with such name does not exist" }, code);
            }

            var result = await _userManager.AddToRoleAsync(user, role);

            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.BadRequest;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();


        }

        public async Task<ServiceResponce> RemoveUserFromRoleAsync(string id, string role)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponse(new List<string>
                                                   {"User with such name does not exist" }, code);
            }

            var result = await _userManager.RemoveFromRoleAsync(user, role);

            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.BadRequest;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();
        }

        public async Task<ServiceResponce> UpdateUserAsync(UpdateDTO model)
        {
            var user =  await _userManager.FindByNameAsync(model.UserName);
            var updatedUser = _mapper.Map<UpdateDTO, User>(model, user);
            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.BadRequest;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();
        }

        public async Task<ServiceResponce> DeleteUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                var code = (int)HttpStatusCode.NotFound;
                return CreateUnsuccessifullResponse(new List<string>
                                                   {"User with such name does not exist" }, code);
            }

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                var code = (int)HttpStatusCode.BadRequest;
                var errorMessages = result.Errors.Select(c => c.Description).ToList();
                return CreateUnsuccessifullResponse(errorMessages, code);
            }

            return new ServiceResponce();

        }

        private ServiceResponce CreateUnsuccessifullResponse(List<string> errorMessages, int statusCode)
        {
            var response = new ServiceResponce();
            response.StatusCode = statusCode;
            response.Success = false;
            response.ErrorMessages.AddRange(errorMessages);
            return response;
        }

        private ServiceResponceWithData<T> CreateUnsuccessifullResponseWithData<T>(List<string> errorMessages, int statusCode)
        {
            var response = new ServiceResponceWithData<T>();
            response.StatusCode = statusCode;
            response.Success = false;
            response.ErrorMessages.AddRange(errorMessages);
            return response;
        }

        public async Task<ServiceResponceWithData<List<SearchResponseDTO>>> SearchAsync(SearchDTO model)
        {
            var users = from user in _userManager.Users
                        join ur in _userRoleRepository.GetAll()
                               on user.Id equals ur.UserId
                        select new SearchResponseDTO
                        {
                            UserName = user.UserName,
                            Email = user.Email,
                            PhoneNumber = user.PhoneNumber,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Roles = _roleManager.Roles
                                    .Where(c => c.Id == ur.RoleId)
                                    .Select(c => c.Name)
                                    .ToList()
                        };

            var startResult = users;

            var props = typeof(SearchDTO).GetProperties();
            foreach (var prop in props)
            {
                if (prop.Name != "Role")
                {
                    users = FilterWithWhere(users, prop, model);
                }
                else
                {
                    if (model.Role != null)
                    {
                        var results = users.Where(c => c.Roles.Any(r => r == model.Role));
                        users = results.Any() ? results : users;
                    }
                }
            }

            var endResultList = startResult == users ? new List<SearchResponseDTO>() : await users.ToListAsync();

            return new ServiceResponceWithData<List<SearchResponseDTO>>() { Data = endResultList, Success = true };
        }

        private IQueryable<SearchResponseDTO> FilterWithWhere(IQueryable<SearchResponseDTO> collection,
                                                    PropertyInfo property, SearchDTO model)
        {
            var propertyName = property.Name;
            var modelPropVal = property.GetValue(model);

            if (modelPropVal == null) return collection;

            dynamic dynamicVal= CastValue(modelPropVal);
            if (dynamicVal == null) return collection;

            string condition = String.Format("{0} == \"{1}\"", propertyName, dynamicVal);
            var fillteredColl = collection.Where(condition);
            return fillteredColl.Any() ? fillteredColl : collection;
        }

        private dynamic CastValue(object value)
        {
            if (value is int) return value as int?;
            if (value is double) return value as double?;
            if (value is float) return value as float?;
            if (value is string) return value as string;
            return null;
        }
    }



        #region New Task From Samir
        //public async Task<ServiceResponce> ResetPassword(UserResetPasswordDTO userChangePasswordDTO)
        //{
        //    IdentityResult result = null;
        //    User user = _userManager.Users.SingleOrDefault(u => u.Id == userChangePasswordDTO.UserId);
        //    if (user == null)
        //    {
        //        //return new OperationResult(false, RequestResults.UserNotFound);
        //    }
        //    string passResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
        //    result = await _userManager.ResetPasswordAsync(user, passResetToken, userChangePasswordDTO.NewPassword);
        //    if (!result.Succeeded)
        //    {
        //        // return new OperationResult(false, RequestResults.NotSuccessful, result.Errors);
        //    }
        //    return new null;
        //}

        // metod olmali User profiler




        #endregion
    
}
