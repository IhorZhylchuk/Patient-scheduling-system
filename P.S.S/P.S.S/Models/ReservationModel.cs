﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P.S.S.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Specialist { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TelNumber { get; set; }
        [Required]
        public string Gender { get; set; }
        

    }
}
