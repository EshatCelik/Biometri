using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }


        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string PhoneNumber2 { get; set; }

        public string Username { get; set; }

        public DateTime? InsertedDate { get; set; }

    }
}
