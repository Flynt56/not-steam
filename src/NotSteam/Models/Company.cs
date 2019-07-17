using System;

namespace NotSteam.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomepageUri { get; set; }
        public string Description { get; set; }
        public string LogoImageUri { get; set; }
    }
}