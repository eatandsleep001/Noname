namespace Noname.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Noname.DAL.NonameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Noname.DAL.NonameContext context)
        {
            List<Employee> Employees = new List<Employee>
            {
                new Employee { EmployeeCode="E001", EmployeePassword="1234" },
                new Employee { EmployeeCode="E002", EmployeePassword="0000" }
            };

            Employees.ForEach(e => context.Employees.AddOrUpdate(p => p.EmployeeCode, e));

            context.SaveChanges();
        }
    }
}
