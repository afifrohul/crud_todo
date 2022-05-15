using CRUD_todo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_todo.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString: "Conn")
        {

        } 

        public virtual DbSet<Todo> TodoObject { get; set; }
    }
}