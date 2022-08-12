using DAL.Context;
using DAL.Domains;
using DAL.Repositories.Abstract;
using DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Helpers.DI
{
    public static class DALDependensis
    {
        public static void SetDALDependensis(this IServiceCollection services,
                                                  IConfiguration configuration)
        {
           
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        }
    }
}
