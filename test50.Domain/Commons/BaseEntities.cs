using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test50.Domain.Commons
{
    public class BaseEntities
    {
        public DateTime? InsertDateTime { get; set; } = DateTime.Now;
        public DateTime? DeleteDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; } 
    }
}
