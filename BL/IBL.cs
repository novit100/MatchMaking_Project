using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        #region Parent
        Parent AddparentToDAL(string firstName, string lastName, string middleName, Gender gender, Origin origin, int seekerId);

        #endregion

        #region User
        User GetUser(string name, string password);
        void AddUser(User user);
        IEnumerable<User> GetAllUsers();
        int HowManyUsers();
        #endregion
    }
}
