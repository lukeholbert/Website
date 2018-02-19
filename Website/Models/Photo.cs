using System;
using System.Collections.Generic;
using System.IO;

namespace Website.Models
{
    public class Photo
    {
        private string name;
        private Tuple<int, int> dimensions;
        private string extension;
        private Album album;

        public Photo(string fileName, Album albumReference)
        {
            name = Path.GetFileNameWithoutExtension(fileName);
            extension = Path.GetExtension(fileName);
            album = albumReference;
            // Set dimensions and other file info
        }

        public override string ToString()
        {
            return name;
        }
    }
}
