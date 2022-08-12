using DP;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{ /// <summary>
  /// The context class is a most important class while working with EF 6 or EF Core. 
  /// It represent a session with the underlying database using which you can perform CRUD 
  /// (Create, Read, Update, Delete) operations.
  /// Shortly-thorough it we can perform operations with the DB.
  /// </summary>
    public class ShidouchimContext : DbContext
    {
        public ShidouchimContext() : base()
        {
        }

        // Entities        
        public DbSet<Acquaintance> Inquirys { get; set; }
        public DbSet<Parent> Parents { get; set; }
        // public DbSet<Person> Persons { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Seeker> Seekers { get; set; }
        public DbSet<Sibiling> Sibilings { get; set; }



    }
}
/*
//FOR ADDING A DBSET FROM OUTSIDE:

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
     
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };
        
                ctx.Students.Add(stud);
                ctx.SaveChanges();                
            }
        }
    }
}

*/