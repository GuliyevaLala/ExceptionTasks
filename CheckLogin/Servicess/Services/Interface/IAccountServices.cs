using Domaiin.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicess.Services.Interface {
    public interface IAccountServices {
        bool CheckLogin(User user);
    }
}
