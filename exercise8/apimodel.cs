using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    public class apimodel
    {       
        public string symbol {  get; set; }
       public float last { get; set; }
        public float changePrice { get; set; }
        public float averagePrice { get; set; }
        public float changeRate { get; set; }       
    }
}
