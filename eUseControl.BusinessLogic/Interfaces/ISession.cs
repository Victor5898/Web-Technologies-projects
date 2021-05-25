using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.Res;
using eUseControl.Domain.Entities.User.Global;
using System.Web;
using eUseControl.Domain.Entities;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        LevelStatus CheckLevel(string key);
        HttpCookie GenCookie(string Credential);
        UserMinimal GetUserByCookie(string CookieApi);
    }
}
