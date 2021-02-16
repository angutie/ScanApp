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
        
        
        [Column("Timestamp")]
        public DateTime CreatedTime{ get; set; }
    

        [Column("Location")] 
        public string Location { get; set; }


        [Column("EmployeeId")]
        public int EmployeeId { get;set; }


        [Column("ScannerId")]
        public int ScannerId { get; set;}
    }

}

