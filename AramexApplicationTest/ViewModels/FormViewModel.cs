using AramexApplicationTest.Models;
using AramexApplicationTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.ViewModels
{
    /// <summary>
    /// IT'S OK TO EDIT THIS FILE
    /// </summary>
    public class FormViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? PetId { get; set; }
        public int? CityId { get; set; }
        public List<Pet> Pets => PetService.GetPets();
        public List<City> Cities => CityService.GetCities();
    }
}