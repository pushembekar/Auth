using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Service.Infrastructure
{
    public interface ITokenProvider
    {
        void ProvideSecurityToken();
    }
}
