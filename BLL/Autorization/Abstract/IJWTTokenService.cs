using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Autorization.Abstract
{
    public interface IJWTTokenService
    {
        string GenerateJwt(IUserClaimsOptions user, IList<string> roles, IJWTOptions jwtSettings);
    }
}
