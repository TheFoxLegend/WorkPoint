﻿using System.ComponentModel.DataAnnotations;

namespace WorkPoint.Models.Entities.Skills
{
    public class MicrosoftOfficeSkills
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Word { get; set; }

        [Required]
        public bool Excel { get; set; }

        [Required]
        public bool Access { get; set; }

        [Required]
        public bool Powerpoint { get; set; }
    }
}
