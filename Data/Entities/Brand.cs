using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Brand :IEntity
    {
        public long Id { get; set; }

       public  string Code { get; set; }
    }
}
