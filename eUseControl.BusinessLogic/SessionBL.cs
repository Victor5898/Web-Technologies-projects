using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.Core;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.User.Global;
using System.Web;
using eUseControl.BusinessLogic.DBModel.Seed;
using eUseControl.Domain.Entities.Session;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using eUseControl.Helpers;
using eUseControl.Domain.Entities;

namespace eUseControl.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data) 
        {
            return UserLoginAction(data);
        }

        public LevelStatus CheckLevel(string key)
        {
            return CheckLevelLogic(key);
        }

        public HttpCookie GenCookie(string Credential)
        {
            return GenerateCookie(Credential);
        }

        public UserMinimal GetUserByCookie(string CookieApi)
        {
            return UserCookie(CookieApi);
        }
    }
}
