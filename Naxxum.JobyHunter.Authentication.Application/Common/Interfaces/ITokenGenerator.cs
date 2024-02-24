using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Application.Common.Interfaces
{
    public interface ITokenGenerator
    {
        //public string GenerateToken(string userName, string password);
        public string GenerateJWTToken((string userId, string userName, IList<string> roles) userDetails);
    }
}
