﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Capas.MVC.Models
{
    public class EmployeeView
    {
        public int EmployeeId { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}