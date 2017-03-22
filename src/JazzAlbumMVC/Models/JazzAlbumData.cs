using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JazzAlbumMVC.Models
{
    public class JazzAlbumData
    {
        private static List<JazzAlbum> JazzAlbums = new List<JazzAlbum>();

        public static void Add(JazzAlbum newJazzAlbum)
        {
            JazzAlbums.Add(newJazzAlbum);
        }

        public static List<JazzAlbum> GetAll()
        {
            return JazzAlbums;
        }

        public static bool Remove(int id)
        {
            return JazzAlbums.Remove(GetById(id));
        }

        public static JazzAlbum GetById(int id)
        {
            return JazzAlbums.Single(x => x.AlbumId == id);
        }
    }
}
