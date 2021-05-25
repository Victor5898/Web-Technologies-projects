using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Product;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class ProductController : BaseController
    {
      
        private readonly IProduct _product;
        public ProductController()
        {
            var bl = new BussinesLogic();
            _product = bl.GetProductBL();
        }
        // GET: Product
        public ActionResult Index()
        {
            SessionStatus();
            if((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
            userData u = new userData();
            /*u.CategoryObj = new List<string> { "Web Design", "Web Development", "Software Development", "Testarea Automata", "Testare Manuala", "Limbajul UML" };
            u.NewsObj = new List<News>();
            u.AchieveObj = new List<Achieve>();
            u.TagObj = new List<string> { "Java", "C#", "UML", "Testare", "Web Design", "Web Develpment", "JavScript", "Testare Manuala" };
            u.CourseObj = new List<ProductDetail>();


            List<string> NewsTitle = new List<string> { "Bazele Testarii Manuale", "Testare Automata in Java", "Bazele C#" };
            List<string> NewsPrice = new List<string> { "250.00", "250.00", "90.00"};

            for(int i = 0; i < 3; i++)
            {
                News news = new News();
                news.News_Img = String.Format("/Content/img/news-" + (i + 1) + ".jpg");
                news.News_Title = NewsTitle[i];
                news.News_Price = NewsPrice[i];

                u.NewsObj.Add(news);
            }

            List<string> AchieveMonth = new List<string> { "May", "June", "July", "August", "September", "Octomber" };
            List<string> AchieveNumber = new List<string> { "25", "100", "120", "34", "56", "75"};

            for(int i = 0; i < 6; i++)
            {
                Achieve achiv = new Achieve();
                achiv.Achieve_Month = AchieveMonth[i];
                achiv.Achieve_Number = AchieveNumber[i];

                u.AchieveObj.Add(achiv);
            }

            List<string> CourseDescription = new List<string> { "Vrei sa inveti tehnicile de testare in limbajul Java? Atunci aplica la acest curs!", "Limbajul C# este un limbaj orientat pe obiecte, foarte utilizat la crearea aplicatiilor web", "UML este cea mai populara aplicatie de modelare a aplicatiilor", "Invata bazele testarii manuale, un domeniu foarte necesar in programele moderne", "Invata HTML, CSS si JavaScript, limbajele de baza in crearea Front-end-ului unei aplicatii", "C# este un limbaj foarte utilizat in crearea aplicatiilor software. Aplica acum!" };
            List<string> CourseName = new List<string> { "Testarea automata in Java", "Bazele C#", "Modelarea aplicatiilor in UML", "Bazele testarii manuale", "Web design (HTML, CSS si JavaScript)", "C# avansat" };
            List<string> CoursePrice = new List<string> { "165.00", "165.00", "165.00", "250.00", "150.00", "90.00"};
            List<string> CourseDaysAfter = new List<string> { "60days", "90days", "50days", "100days",  "90ddays", "120days" };
            List<string> CourseId = new List<string> { "course#1", "course#2", "course#3", "course#4", "course#5", "course#6" };

            for (int i = 0; i < 6; i++)
            {
                Course eo = new Course();
                eo.Course_Img = String.Format("/Content/img/courses/" + (i + 1) + ".jpg");
                eo.Course_Descript = CourseDescription[i];
                eo.Course_Name = CourseName[i];
                eo.Course_Price = CoursePrice[i];
                eo.Course_Days = CourseDaysAfter[i];
                eo.Course_Id = CourseId[i];

                u.CourseObj.Add(eo);
            }*/

            List<ProductDetail> prodData = _product.GetProduct();
            userData ud = new userData();
            ud.CourseObj = prodData;
            //return RedirectToAction("Course", "Product", new { });
            return View(ud);

            //return View();
        }

        public ActionResult Course()
        {
            var course = Request.QueryString["c"];
            userData u = new userData();
            u.Username = "Custumer";

            u.SingleCourse = course;


            u.CategoryObj = new List<string> { "Web Design", "Web Development", "Software Development", "Testarea Automata", "Testare Manuala", "Limbajul UML" };
            u.NewsObj = new List<News>();
            u.AchieveObj = new List<Achieve>();
            u.TagObj = new List<string> { "Java", "C#", "UML", "Testare", "Web Design", "Web Develpment", "JavScript", "Testare Manuala" };
            u.CourseObj = new List<ProductDetail>();


            u.CDetails = new CourseDetails {CName = "AAAAAAA" };

            return View(u);
        }

        [HttpPost]
        public ActionResult GetCourse(string btn)
        {
            return RedirectToAction("Course", "Product", new { @c = btn});
        }
    }
}