using System.Collections.Generic;
namespace JazzAlbumMVC.Models
{
    public class JazzAlbum
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Tracks { get; set; }
        public List<string> BandMembers { get; set; }

        public int AlbumId { get; set; }
        private static int nextId = 1;

        public JazzAlbum()
        {
            AlbumId = nextId;
            nextId++;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.AlbumId == (obj as JazzAlbum).AlbumId;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return AlbumId;
        }
    }
}
