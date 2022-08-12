using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Person
    {   //It says that the id is a primary key and the EF creates it as a serial number automatically
        //NOTE:if I would want to add an xml database i will need to add an xml file that keeps the first and last number
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }    //serial running number 
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


    }
}
