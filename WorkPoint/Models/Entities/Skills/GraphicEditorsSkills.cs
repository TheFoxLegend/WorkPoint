﻿using System.ComponentModel.DataAnnotations;

namespace WorkPoint.Models.Entities.Skills
{
    public class GraphicEditorsSkills
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool VSCO { get; set; }

        [Required]
        public bool Snapseed { get; set; }

        [Required]
        public bool Lightroom { get; set; }

        [Required]
        public bool Photoshop { get; set; }
    }
}
