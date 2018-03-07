using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CSharp2018Project.Models
{
    public class Drink
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Category { get; set; }
       [Range(0, 10, ErrorMessage = "Please enter a value between 0 and 10.")]
       public int? Score { get; set; }
    }


}