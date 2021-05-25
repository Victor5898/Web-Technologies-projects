using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class AddedProduct
    {
        public int Id { get; set; }

        [Required]
        public string ProdName { get; set; }
        [Required]
        public string ProdDescription { get; set; }

        public string Duration { get; set; }

        public string ProdImg { get; set; }

        public int ProdPrice { get; set; }
    }
}