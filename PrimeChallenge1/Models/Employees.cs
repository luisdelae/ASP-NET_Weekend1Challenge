using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PrimeChallenge1.Models
{
    public class Employees
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name="Emp ID")]
        public int IdNum { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }
    }
}