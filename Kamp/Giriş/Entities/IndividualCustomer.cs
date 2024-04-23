using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris.Entities
{
    public class IndividualCustomer:BaseCustomer
    {
     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdetity { get; set; }
    }
}
