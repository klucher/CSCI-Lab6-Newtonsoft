using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI2910_Lab6_Newtonsoft.Models
{
    internal class Book
    {
        public string Id { get; set; }
        public VolumeInfo VolumeInfo { get; set; }
        public string SelfLink { get; set; }

        public Book(string id, VolumeInfo volumeInfo, string selfLink)
        {
            Id = id;
            VolumeInfo = volumeInfo;
            SelfLink = selfLink;
        }

        public override string ToString()
        {

            string bookString = "";
            bookString += $"\nId: {Id}\n";
            bookString += $"\nTitle: {VolumeInfo.Title}\n";
            bookString += $"\nAuthors: {String.Join(", ", VolumeInfo.Authors)}\n";
            bookString += $"\nDescription: {VolumeInfo.Description}\n";
            bookString += $"\nSelfLink: {SelfLink}\n\n";
            bookString += $"\n----------------------\n\n";
            return bookString;
        }
    }
}
