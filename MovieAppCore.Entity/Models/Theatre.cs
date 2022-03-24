using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieAppCore.Entity.Models
{
   public class Theatre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ThatereId { get; set; }
        public string Name { get; set; }
    }
}
