using System.ComponentModel.DataAnnotations;
using JazzAlbumMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace JazzAlbumMVC.ViewModels
{
    public class AddJazzAlbumViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public List<string> Tracks { get; set; }

        //public AddJazzAlbumViewModel()
        //{
           
        //}
    }
}
