using Domaiin.BaseEntity;
using Servicess.Exceptions;
using Servicess.Exceptions.Constant;
using Servicess.Services.Interface;
using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Servicess.Services {
   public class AccountServices: IAccountServices {
        public bool CheckLogin(User user) 
        {
            if(Regex.IsMatch(user.Email, @"^(\w+?@\w+?\x2E.+)$"))
            {
                if(Regex.IsMatch(user.Username, @"[a - zA - Z](([\._\-][a - zA - Z0 - 9]) |[a - zA - Z0 - 9]) *[a - z0 - 9]$"))
                {
                    if (Regex.IsMatch(user.Passcode, @"[a - zA - Z](([\._\-][a - zA - Z0 - 9]) |[a - zA - Z0 - 9]) *[a - z0 - 9]$"))
                    {
                        return true;

                    }

                }
            }
            throw new LoginExceprion(Messages.ErrorMessage);

        }
    }
}
