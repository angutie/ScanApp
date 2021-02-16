using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace mentor_3.Models
{
    public class PostingScans    {
        public DateTime Time{ get; set; }
    
        public string Location { get; set; }
        
        public int Id { get;set; }

        public string ScannerId { get; set;}
    }

}