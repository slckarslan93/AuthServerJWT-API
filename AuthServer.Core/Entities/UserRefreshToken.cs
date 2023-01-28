using System;

namespace AuthServer.Core.Entities
{
    public class UserRefreshToken
    {
        public string UserID { get; set; }
        public string Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}