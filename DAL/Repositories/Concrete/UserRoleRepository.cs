using DAL.Context;
using DAL.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly OnionDbContext _context;

        public UserRoleRepository(OnionDbContext context)
        {
            _context = context;
        }

        public IQueryable<IdentityUserRole<Guid>> GetAll()
        {
            return _context.UserRoles;
        }
    }
}
