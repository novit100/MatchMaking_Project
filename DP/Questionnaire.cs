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
        public string FinancialHelp { get; set; }
        public bool transferPhoto { get; set; }
        public string Email { get; set; }
        public string PhoneNumberForOfferings { get; set; }

        public bool AreParentsDivorced { get; set; }
        public string HealthCondition { get; set; }
        public List<Interest> Interests { get; set; }
        public bool DoesWork { get; set; }//not sure if to add the profession here or in the questionnair


    }
}
