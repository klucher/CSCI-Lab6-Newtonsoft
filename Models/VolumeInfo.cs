using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI2910_Lab6_Newtonsoft.Models
{
    internal class VolumeInfo
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }

        public VolumeInfo(string title, List<string> authors, string description)
        {
            Title = title;
            Authors = authors;
            Description = description;
        }
    }
}
