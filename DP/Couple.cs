using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Couple
    {
        [Key]
        public int SeekerBoyId { get; set; }
        [Key]
        public int SeekerGirlId { get; set; }
        public CoupleStatus CoupleStatus { get; set; }
        public bool PaidTheFee { get; set; }//the default needs to be false

    }
}
