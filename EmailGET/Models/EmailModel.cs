using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace EmailGET.Models
{
    public class EmailModel
    {
        public int _id { get; set; }
        public string name { get; set; }
        public string body { get; set; }
        public bool published { get; set; }
         

    }
}