using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstract
{
    public interface IUserRoleRepository
    {
        IQueryable<IdentityUserRole<Guid>> GetAll();
    }
}
