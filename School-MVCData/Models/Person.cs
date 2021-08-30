using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCData.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
