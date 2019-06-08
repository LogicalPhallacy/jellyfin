using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediaBrowser.Controller.Authentication;
using MediaBrowser.Controller.Entities;

namespace Emby.Server.Implementations.Library
{
    class InvalidAuthProvider : IAuthenticationProvider
    {
        public string Name => "InvalidorMissingAuthenticationProvider";

        public bool IsEnabled => true;

        public async Task<ProviderAuthenticationResult> Authenticate(string username, string password)
        {
            throw new Exception("User Account cannot login with this provider. The Normal provider for this user cannot be found");
        }

        public async Task<bool> HasPassword(User user)
        {
            return false;
        }

        public async Task ChangePassword(User user, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void ChangeEasyPassword(User user, string newPassword, string newPasswordHash)
        {
            throw new NotImplementedException();
        }

        public string GetPasswordHash(User user)
        {
            throw new NotImplementedException();
        }

        public string GetEasyPasswordHash(User user)
        {
            throw new NotImplementedException();
        }
    }
}
