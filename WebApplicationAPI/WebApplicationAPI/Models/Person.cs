using System;
using System.Collections.Generic;

namespace WebApplicationAPI.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
    }
}
