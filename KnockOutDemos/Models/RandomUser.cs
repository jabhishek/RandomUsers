using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockOutDemos.Models
{
    public class RandomUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string ImageUrl { get; set; }
    }
}