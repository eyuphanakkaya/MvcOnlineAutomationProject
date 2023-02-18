using MvcOnlineAutomationProject.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcOnlineAutomationProject.Models.EntityFramwork
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Departmant> Departmants { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<SalesMovement> SalesMovements { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}