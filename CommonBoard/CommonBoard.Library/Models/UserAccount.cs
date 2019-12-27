using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoard.Library.Models
{
    public class UserAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
