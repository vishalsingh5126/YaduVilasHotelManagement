using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaduVilasHM.Models
{
    public class User
    {
        public User()
        {
            Sections = new List<Section>();
            Role = new Role();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public List<Section> Sections { get; set; }
    }
}
