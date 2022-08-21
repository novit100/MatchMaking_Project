using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class PlaceForDate
    {
        [Key]
        public int id { get; set; }
        public string PlaceName { get; set; }
        public string   Placeaddress { get; set; }
        public string PlaceSubscription { get; set; }
        public string Kashroot { get; set; }
        public string City { get; set; }


    }
}
