using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace mentor_3.Models
{
    public class MyModel
    {
        public DateTime MyData { get; set; }
        public List<string> Names { get; internal set; }

        public string Location { get; set; }
        

        public double Money { get; internal set; }

        public int Id { get;set; }

        public string Address {get;set;}

        public string ScannerId { get; set;}
    }

}