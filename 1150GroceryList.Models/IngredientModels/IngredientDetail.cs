﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Models.IngredientModels
{
    public class IngredientDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsOrganic { get; set; }
    }
}
