using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DbInlämningsuppgift1
{
    class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }

        [Column(TypeName ="date")]
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return Name;
        }


    }
}
