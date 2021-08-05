using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseholdMangement.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Quantity")]
        public int Qty { get; set; }


        public Items items { get; set; }
    }
}
