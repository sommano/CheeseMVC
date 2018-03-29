using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }
    }
}