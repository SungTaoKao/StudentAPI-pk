namespace StudentAPI.Migrations.Directory
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Directory";
        }

        protected override void Seed(StudentAPI.Models.ApplicationDbContext context)
        {
            context.Students.AddOrUpdate(
                s => s.StudentId,
                DummyData.GetStudent().ToArray()
                );

            context.SaveChanges();
        }
    }
}
