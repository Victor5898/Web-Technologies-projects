using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Product;

namespace eUseControl.Web.Controllers
{
    public class ProductDetailController : Controller
    {
        private IProduct _product;
        // GET: ProductDetail
        ProductDetailController()
        {
            BussinesLogic bussinesl = new BussinesLogic();

            _product = bussinesl.GetProductBL();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetProduct(int id)
        {

            ProductDetail prodDetail = _product.GetDetailProduct(id);
            return View();
        }

    }
}