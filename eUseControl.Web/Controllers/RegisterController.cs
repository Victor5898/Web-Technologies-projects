using AutoMapper;
using eUseControl.BusinessLogic.DBModel.Seed;
using eUseControl.Domain.Entities;
using eUseControl.Domain.Entities.User;
using eUseControl.Helpers;
using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(userRegister register)
        {
            URegisterResp reg = new URegisterResp();
            if(ModelState.IsValid)
            {
                if(register.Confirm == register.Password)
                {
                    register.Password = LoginHelper.HashGen(register.Password);
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<userRegister, UDbTable>();
                    });

                    IMapper iMapper = config.CreateMapper();
                    var localProd = iMapper.Map<userRegister, UDbTable>(register);
                    using (UserContext prod = new UserContext())
                    {
                        prod.Users.Add(localProd);
                        prod.SaveChanges();
                    }
                }
                else
                {
                    ModelState.AddModelError("Parolele nu coincid!", reg.StatusMessage);
                    return View();
                }
                
            }
            return RedirectToAction("Index", "Login");
        }
    }
}