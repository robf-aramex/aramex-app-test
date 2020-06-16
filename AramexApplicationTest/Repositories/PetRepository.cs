using AramexApplicationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.Repositories
{
    public static class PetRepository
    {
        public static List<Pet> Pets = new List<Pet>() {
                new Pet(1, "Dog"),
                new Pet(2, "Cat"),
                new Pet(3, "Lion"),
                new Pet(4, "Tiger"),
            };
    }
}