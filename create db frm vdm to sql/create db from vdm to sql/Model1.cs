namespace ConsoleApp33
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Suriya : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ConsoleApp33.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Suriya() : base("MyDbconstr")
        {
            Database.SetInitializer<Suriya>(new DropCreateDatabaseIfModelChanges<Suriya>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(p => p.Dep_name).HasMaxLength(20);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public class Employee
    {
        public int Employeeid { get; set; }
        [MaxLength(20)]
        [StringLength(20)]
        [Column(name:"EmployeeName")]
        public string Emp_name { get; set; }
        public double Salary { get; set; }

    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Dep_name { get; set; }

    }

}