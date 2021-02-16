using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mentor_3.Models
{
    [Table("ScanLog")]
    public class PostingScans    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get;set; }
        public DateTime Time{ get; set; }
    
        public string Location { get; set; }
        
        public int Employee { get;set; }

        public int ScannerId { get; set;}
    }

}

