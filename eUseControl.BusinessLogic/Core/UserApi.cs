using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.Res;
using eUseControl.Domain.Entities.User.Global;
using eUseControl.Domain.Entities.Product;
using eUseControl.BusinessLogic.DBModel.Seed;
using eUseControl.Domain.Enums;
using System.Data.Entity;
using AutoMapper;
using System.ComponentModel.DataAnnotations;
using eUseControl.Helpers;
using System.Web;
using eUseControl.Domain.Entities.Session;
using eUseControl.Domain.Entities;

namespace eUseControl.BusinessLogic.Core
{
    public class UserApi
    {
        internal ActionStatus UserLogData(ULoginData data)
        {
            return new ActionStatus();
        }

        internal LevelStatus CheckLevelLogic(string keySession)
        {
            return new LevelStatus();
        }

        internal ProductDetail GetProdUser(int id)
        {
            return new ProductDetail();
        }

        internal List<ProductDetail> GetProdAction()
        {
            List<PDbTable> product;

            List<ProductDetail> pData = new List<ProductDetail>();
            Database.SetInitializer<ProductContext>(null);
            using (var db = new ProductContext())
            {
                product = db.Products.ToList();
            }

            foreach(var prod in product)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<PDbTable, ProductDetail>();
                });

                IMapper iMapper = config.CreateMapper();
                var localProd = iMapper.Map<PDbTable, ProductDetail>(prod);

                pData.Add(localProd);
            }

            return pData;
        }

        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UDbTable user;
            var validateEmail = new EmailAddressAttribute();
            var password = LoginHelper.HashGen(data.Password);
            if (validateEmail.IsValid(data.Credential))
            {
                using (var db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Username == data.Credential /*&& u.Password == password*/);
                }

                if (user == null)
                {
                    return new ULoginResp { Status = false, StatusMessage = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    user.UserIp = data.LoginIp;
                    user.lastLogin = data.LoginDataTime;
                    todo.Entry(user).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
            else
            {
                using (var db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Username == data.Credential /*&& u.Password == password*/);
                }

                if (user == null)
                {
                    return new ULoginResp { Status = false, StatusMessage = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    user.UserIp = data.LoginIp;
                    user.lastLogin = data.LoginDataTime;
                    todo.Entry(user).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
            
        }

        internal HttpCookie GenerateCookie(string Credential)
        {
            var apiCookie = new HttpCookie("X-KEY")
            {
                Value = CookieGenerator.Create(Credential)
            };

            using (var db = new SessionContext())
            {
                DbSession currentCookie;
                var validate = new EmailAddressAttribute();
                if (validate.IsValid(Credential))
                {
                    currentCookie = (from e in db.Sessions where e.Username == Credential select e).FirstOrDefault();
                }
                else
                {
                    currentCookie = (from e in db.Sessions where e.Username == Credential select e).FirstOrDefault();
                }

                if (currentCookie == null)
                {
                    db.Sessions.Add(new DbSession { Username = Credential, CookieString = apiCookie.Value, ExpireTime = DateTime.Now.AddMinutes(60) });
                    db.SaveChanges();
                }
                else
                {
                    currentCookie.CookieString = apiCookie.Value;
                    currentCookie.ExpireTime = DateTime.Now.AddMinutes(60);
                    using (var todo = new SessionContext())
                    {
                        todo.Entry(currentCookie).State = EntityState.Modified;
                        todo.SaveChanges();
                    }
                }
            }
            return apiCookie;
        }

        internal UserMinimal UserCookie(string CookieApi)
        {
            DbSession session;
            UDbTable curentUser;

            using (var db = new SessionContext())
            {
                session = db.Sessions.FirstOrDefault(s => s.CookieString == CookieApi && s.ExpireTime > DateTime.Now);
            }

            if (session == null)
            {
                return null;
            }
            using (var db = new UserContext())
            {
                var validate = new EmailAddressAttribute();
                if (validate.IsValid(session.Username))
                {
                    curentUser = db.Users.FirstOrDefault(u => u.Email == session.Username);
                }
                else
                {
                    curentUser = db.Users.FirstOrDefault(u => u.Username == session.Username);
                }
            }
            if (curentUser == null)
            {
                return null;
            }
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UDbTable, UserMinimal>();
            });
            IMapper iMapper = config.CreateMapper();
            var userminimal = iMapper.Map<UserMinimal>(curentUser);

            return userminimal;
        }
    }
}
