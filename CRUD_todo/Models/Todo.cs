using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_todo.Models
{
    [Table("todo", Schema="public")]
    public class Todo
    {
        [Key]
        public int id { get; set; }
        public string task { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public DateTime end_date { get; set; }
        public string status { get; set; }
    }
}