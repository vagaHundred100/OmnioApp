using BLL.Domains;
using BLL.DTO;
using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IAccauntService
    {
        Task<ServiceResponceWithData<List<SearchResponseDTO>>> SearchAsync(SearchDTO model);
        Task<ServiceResponce> ActivateUserAsync(string userName);
        Task<ServiceResponce> AddUserToRoleAsync(string userName, string role);
        Task<ServiceResponce> ChangePasswordAsync(ChangePasswordDTO model);
        Task<ServiceResponce> DeactivateUserAsync(string userName);
        Task<ServiceResponce> DeleteUserAsync(string userName);
        ServiceResponceWithData<List<UserIndexDTO>> GetAllUsersAsync();
        Task<ServiceResponceWithData<string>> LoginAsync(LoginDTO model);
        Task<ServiceResponce> RegisterAsync(RegisterDTO model);
        Task<ServiceResponce> RemoveUserFromRoleAsync(string userName, string role);
        Task<ServiceResponce> ResetPasswordAsync(RisetPasswordDTO model);
        Task<ServiceResponce> UpdateUserAsync(UpdateDTO model);
    }
}
