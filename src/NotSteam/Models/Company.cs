using System;

namespace NotSteam.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri HomepageUri { get; set; }
        public string Description { get; set; }
        public Uri LogoImageUri { get; set; }
    }
}