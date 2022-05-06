using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ContactList.Models
{
    public class Contact
    {
        //ef core configures database to generate contactID
        public int ContactID { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string LName { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public string Organization{ get; set; }
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string Slug => FName + LName.Replace(' ', '-').ToLower();

    }
}
