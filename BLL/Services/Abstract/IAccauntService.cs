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
        Task<ResponceWithData<List<SearchResponseDTO>>> SearchAsync(SearchDTO model);
        Task<Responce> ActivateUserAsync(string Id);
        Task<Responce> AddUserToRoleAsync(string Id, string role);
        Task<Responce> ChangePasswordAsync(ChangePasswordDTO model);
        Task<Responce> DeactivateUserAsync(string Id);
        Task<Responce> DeleteUserAsync(string Id);
        ResponceWithData<List<UserIndexDTO>> GetAllUsersAsync();
        Task<ResponceWithData<string>> LoginAsync(LoginDTO model);
        Task<Responce> RegisterAsync(RegisterDTO model);
        Task<Responce> RemoveUserFromRoleAsync(string Id, string role);
        Task<Responce> ResetPasswordAsync(RisetPasswordDTO model);
        Task<Responce> UpdateUserAsync(UpdateDTO model);
    }
}
