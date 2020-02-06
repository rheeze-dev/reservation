using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsinTransientAndApartment.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
    }
}
