using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Each of the classes would have its own CRUD functions
    /// -we decided not to do the class as an interface because we dont neet to support 
    /// -other implementations of DAL (as xml, etc.)
    /// this is an interface that declares the CRUD functions of each class 
    /// that would be implemented in the DAL class
    /// NOTE:if we'll have another IDAL implementation (as xml, etc.) we will could create a DLFactory and a configuration file 
    /// in witch we will choose the type of object we want to work eith.
    /// </summary>
    public interface IDAL
    {


        #region Acquaintance
        IEnumerable<Acquaintance> GetAllAcquaintances();
        #endregion

        #region Parent
        IEnumerable<Parent> GetParentsOfSeeker(int seekerId);
        Parent GetParent(int parentId);
        int AddParent(string firstName, string lastName, string middleName, Gender gender, Origin origin, int seekerId);
        void DeleteParent(int parentId);

        #endregion

        /* #region Person
         IEnumerable<Person> GetAllPersons();
         int AddPerson(int PersonId, Gender gender, Origin origin);
         void DeletePerson(int PersonId);
         #endregion
 */

        #region Questionnaire
        #endregion

        #region Seeker

        #endregion

        #region Sibiling
        #endregion

    }
}
