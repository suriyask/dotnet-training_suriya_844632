


namespace ConsoleApp6
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class table : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'ConsoleApp6.Model1' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'Model1'
        // connection string in the application configuration file.
        public table()
            : base("MyDbConstr")
        {
            Database.SetInitializer<table>(new DropCreateDatabaseIfModelChanges<table>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TrainingRequest> TrainingRequests { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public class User
    {
        public int Userid { get; set; }

        [MaxLength(30)]
        [StringLength(20)]
        public string name { get; set; }


        [MaxLength(20)]
        [StringLength(10)]

        public string Username { get; set; }

        [MaxLength(15)]
        [StringLength(8)]
        public string Password { get; set; }
    }
    public class TrainingRequest
    {
        public int id { get; set; }

        [MaxLength(40)]
        [StringLength(30)]
        public string reqname { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }

        [MaxLength(40)]
        [StringLength(10)]
        public string skill { get; set; }
        [ForeignKey("owner")]

        public int ownedid { get; set; }
        public virtual User owner { get; set; }
        public int? executiveid { get; set; }
        public string status { get; set; }

    }

}


