using System;
using System.Collections.Generic;
using System.IO;

namespace Website.Models
{
    public class Album
    {
        private string name;
        private string albumPath;
        private List<Photo> photos = new List<Photo>();
        private AlbumCollection collection;
        
        public Album(string newName, AlbumCollection collectionReference)
        {
            name = newName;
            albumPath = "~/images/" + name;
            collection = collectionReference;

            foreach(var photoFile in Directory.EnumerateFiles(albumPath))
            {
                GetPhoto(photoFile);
            }
        }

        public void GetPhoto(string fileName)
        {
            photos.Add(new Photo(fileName, this));
        }

        // Figure out how to get uploaded photo data to save to file
        public void AddPhoto(string newPhoto)
        {
            
        }

        public override string ToString()
        {
            return name;
        }
    }
}
