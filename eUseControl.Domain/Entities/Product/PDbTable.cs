using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.Product
{
    public class PDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime DaysAfter { get; set; }
        public int ProdPrice { get; set; }
        public string ProdImg { get; set; }
        /*public string ProdDuration { get; set; }
        public int CategoryId { get; set; }
        public DateTime Start { get; set; }*/
    }
}
