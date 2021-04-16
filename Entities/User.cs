using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace AppUser.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public float Height { get; set; }
    
    }
}