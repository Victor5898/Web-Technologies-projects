using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Enums;
using eUseControl.Domain.Entities.User.Global;
using eUseControl.Web.Models;
using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.DBModel.Seed;
using AutoMapper;
using AutoMapper.Configuration;

namespace eUseControl.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(userLogin login)
        { 
            if(ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<userLogin, ULoginData>();
                });

                IMapper iMapper = config.CreateMapper();
                var data = iMapper.Map<userLogin, ULoginData>(login);

                data.LoginIp = Request.UserHostAddress;
                data.LoginDataTime = DateTime.Now;

                var UserLogin = _session.UserLogin(data);
                if (UserLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                     ModelState.AddModelError("Nume de utilizator sau parola incorecta. Va rugam sa incercati din nou!", UserLogin.StatusMessage);
                     return View();
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}