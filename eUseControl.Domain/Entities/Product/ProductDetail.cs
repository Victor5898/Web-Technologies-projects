using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.Lessons;

namespace eUseControl.Domain.Entities.Product
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int UserID {get; set;}
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }
        public string Duration { get; set; }
        public DateTime DaysAfter { get; set; }
        public string ProdImg { get; set; }
        public int ProdPrice { get; set; }
        public List<Outline> OutlineObj { get; set; }  
    }
}
