using System.Collections.Generic;

namespace ly.MyBarRepository.Models
{
    public class Address
    {
        public string building { get; set; }
        public List<double> coord { get; set; }
        public string street { get; set; }
        public string zipcode { get; set; }
    }
}