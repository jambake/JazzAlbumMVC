using System;
using System.Collections.Generic;
using JazzAlbumMVC.Models;

namespace JazzAlbumMVC.ViewModels
{
    public class AllJazzAlbumsViewModel
    {
        public List<JazzAlbum> JazzAlbums { get; set; }

        public AllJazzAlbumsViewModel()
        {
            JazzAlbums = JazzAlbumData.GetAll();
        }

    }
}
