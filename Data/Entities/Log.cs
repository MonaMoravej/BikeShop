using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   
    public class Log 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long Id { get; set; }
       
        
        public string UserName{ get; set; } 

       
        public DateTime LogDateTime { get; set; }

        
        public string Level { get; set; }

       
        public string LogObject { get; set; }

        
        public string Message { get; set; }

       
        public string Exception { get; set; }

        
        public string Data { get; set; }

    }
}
