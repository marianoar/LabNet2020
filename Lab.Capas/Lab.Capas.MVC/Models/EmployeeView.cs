using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Capas.MVC.Models
{
    public class EmployeeView
    {
        public int EmployeeId { get; set; }
        
        [Required] // verificar
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}