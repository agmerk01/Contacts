﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace ContactList.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
