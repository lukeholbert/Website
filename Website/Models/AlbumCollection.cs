using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Website.Models
{
    public class AlbumCollection
    {
        private List<Album> albums = new List<Album>();
        private string path = "~/images";

        public AlbumCollection()
        {
            foreach(var albumName in Directory.EnumerateDirectories(path))
            {
                GetAlbum(albumName);
            }
        }

        public void GetAlbum(string albumName)
        {
            albums.Add(new Album(albumName, this));
        }

        public void AddAlbum(string albumName)
        {
            Directory.CreateDirectory(path + "/" + albumName);
            albums.Add(new Album(albumName, this));
        }
    }
}
