using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Enums;

namespace eUseControl.Domain.Entities
{
    public class UserMinimal
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime lastLogin { get; set; }
        public string UserIp { get; set; }
        public LevelAcces Level { get; set; }
    }
}
