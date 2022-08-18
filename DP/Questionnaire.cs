using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Questionnaire
    {
        [Key] //the attribute SeekerId will be the key of Questionnaires table while building the EF database 
              //(in this case the id of the class is'nt written excplicitly 
              //so we need to reference the program to the specific key we want it to use
        public int SeekerId { get; set; }
       
         
        public string Email { get; set; }
        public string PhoneNumberForOfferings { get; set; }

        public bool? transferPhoto { get; set; }

        public FinancialHelp? FinancialHelp { get; set; }
       
       
        public bool? AreParentsMarriedWithEachOther { get; set; }
        public string HealthCondition { get; set; }
        public List<Interest> Interests { get; set; }
        
        public IQ IQ { get; set; }//חכמה שכלית
        public intellect intellect { get; set; }//אינטיליגנציה כללית
        public Torah_Study_InFuture Torah_Study_InFuture { get; set; }

        public string Remarks { get; set; }


    }
}
