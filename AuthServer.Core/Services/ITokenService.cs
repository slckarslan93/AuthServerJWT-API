using AuthServer.Core.Configuration;
using AuthServer.Core.Dtos;
using AuthServer.Core.Entities;
using AuthServer.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}