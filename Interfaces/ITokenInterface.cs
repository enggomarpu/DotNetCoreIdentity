using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppIdentity.Entities;

namespace DotNetCoreIdentity.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}