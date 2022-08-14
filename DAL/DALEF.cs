using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// DAL implementation using Entity Framework
    /// </summary>
    sealed class DALEF : IDAL
    {
        #region Singelton 
        //We need a singelton so that only one IDAL implementation of DALEF will be created 
        //because its not a data object but a functional one.
        static readonly DALEF instance = new DALEF();
        static DALEF() { }// static ctor to ensure instance init is done just before first usage
        DALEF() { } // default => private
        public static DALEF Instance { get => instance; }// The public Instance property to use
        #endregion


        //creating our entity framework dataBase
        ShidouchimContext ShidCtx = new ShidouchimContext();



        #region Acquaintance
        public IEnumerable<Acquaintance> GetAllAcquaintances()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Parent
        public IEnumerable<Parent> GetParentsOfSeeker(int seekerId)
        {
            throw new NotImplementedException();
        }
        public Parent GetParent(int parentId)
        {
            Parent parent = ShidCtx.Parents
                    .Where(b => b.Id == parentId)
                    .FirstOrDefault();
            return parent;
        }

        public int AddParent(string firstName, string lastName, string middleName, Gender gender, Origin origin, int seekerId)
        {
            Parent parent = new Parent() { FirstName = firstName, MiddleName = middleName, LastName = lastName, SeekerId = seekerId, Gender = gender, FathersOrigin = origin };
            ShidCtx.Parents.Add(parent);
            ShidCtx.SaveChanges();
            Console.WriteLine(parent.Id);
            return parent.Id;
        }

        public void DeleteParent(int parentId)
        {
            throw new NotImplementedException();
        }
        #endregion



    }
}
