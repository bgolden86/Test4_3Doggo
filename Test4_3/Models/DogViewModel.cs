using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Test4_3.Models
{
    public class DogViewModel
    {
        public string? DogName { get; set; }

        public int Age { get; set; }

        public string? Breed { get; set; }

        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public double Zipcode { get; set; }
    }
}
