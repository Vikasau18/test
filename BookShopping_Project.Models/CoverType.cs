﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopping_Project.Models
{
   public class CoverType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
