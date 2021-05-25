using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eUseControl.Domain.Enums;


namespace eUseControl.Domain.Entities.User
{
    public class UDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The username cannot be shorter than 6 characters")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "The password cannot be shorter than  8 characters")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email Adress")]
        [StringLength(30)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime lastLogin { get; set; }

        [StringLength(25)]
        public string UserIp { get; set; }

        public LevelAcces Level { get; set; }
    }

}
