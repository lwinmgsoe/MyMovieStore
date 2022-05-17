﻿using System.ComponentModel.DataAnnotations;

namespace MyMovieStore.Domain.Models
{
    public class Language
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
