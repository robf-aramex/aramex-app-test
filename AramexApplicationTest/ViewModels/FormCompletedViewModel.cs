using AramexApplicationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.ViewModels
{
    public class FormCompletedViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Pet Pet { get; set; }
        public City City { get; set; }
    }
}