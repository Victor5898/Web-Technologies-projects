using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web;
using eUseControl.BusinessLogic.ActionFilter;
using eUseControl.Domain.Entities.Product;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic;
using AutoMapper;
using eUseControl.BusinessLogic.DBModel.Seed;
using System.ComponentModel.DataAnnotations.Schema;

namespace eUseControl.Web.Controllers
{
    [Table("PDbTables")]
    public class AdminController : Controller
    {
        private readonly IProduct _product;
        public AdminController()
        {
            var bl = new BussinesLogic();
            _product = bl.GetProductBL();
        }
        // GET: Admin

        [AdminMod]
        public ActionResult Index()
        {
            List<ProductDetail> courseList = _product.GetProduct();
            userData udata = new userData();
            var course = udata.CourseObj;
            foreach (var prod in courseList)
            {
                course.Add(new ProductDetail
                {
                    Id = prod.Id,
                    UserID = prod.UserID,
                    ProdName = prod.ProdName,
                    ProdDescription = prod.ProdDescription,
                    Duration = prod.Duration,
                    DaysAfter = prod.DaysAfter,
                    ProdImg = prod.ProdImg,
                    ProdPrice = prod.ProdPrice,
                    OutlineObj = prod.OutlineObj

                });
            }

            return View(udata);
        }

        [AdminMod]
        public ActionResult AddProduct()
        {
            AddedProduct course = new AddedProduct();
            return View(course);
        }

        [HttpPost]
        [AdminMod]
        public ActionResult AddProduct(AddedProduct course)
        {
            if(ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<AddedProduct, PDbTable>();
                });

                IMapper iMapper = config.CreateMapper();
                var localProd = iMapper.Map<AddedProduct, PDbTable>(course);
                using (ProductContext prod  = new ProductContext())
                {
                    prod.Products.Add(localProd);
                    prod.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Product");
        }
    }
}