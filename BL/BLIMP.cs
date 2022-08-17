using DAL;
using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class BLIMP : IBL
    {
        #region Singelton 
        //We need a singelton so that only one IDAL implementation of BLIMP will be created 
        //because its not a data object but a functional one.
        static readonly BLIMP instance = new BLIMP();
        static BLIMP() { }// static ctor to ensure instance init is done just before first usage
        BLIMP(){ }// default => private
        public static BLIMP Instance { get => instance; }// The public Instance property to use
        #endregion



        IDAL dal=DALFactory.GetDAL();


        public Parent AddparentToDAL(string firstName, string lastName, string middleName, Gender gender, Origin origin, int seekerId)
        {
            int id = dal.AddParent(firstName, lastName, middleName, gender, origin, seekerId);
            Parent parent = dal.GetParent(id);
            return parent;
        }
         
        #region User
       
        /// <summary>
        /// returns the user with the given name and password
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>user bo</returns>
        public User GetUser(string name, string password)
        {
            User user;
            try
            {
                user = dal.GetUser(name, password);
            }
            catch (UserException ex)
            {
                throw new Exception("The user with this password wasn't found\n", ex);
            }
            return user;
        }

        /// <summary>
        /// add a user
        /// </summary>
        /// <param name="user">user</param>
        public void AddUser(User user)
        {
            try
            {
                dal.AddUser(user);
            }
            catch (UserException ex)
            {
                throw new UserException(user.UserName,"couldn't add the user\n", ex);
            }
        }
     
        /// <summary>
        /// returns IEnumerable of all the users
        /// </summary>
        /// <returns>users</returns>
        public IEnumerable<User> GetAllUsers()
        {
            return from item in GetAllUsers()
                   select item;
        }

        public int HowManyUsers()
        {
            return dal.HowManyUsers();
        }
        #endregion
    }
}
