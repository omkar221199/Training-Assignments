using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
    public class MultipleOptions
    {
        public int TranID { get; set; }
        public int UserID { get; set; }
        public DateTime TranDate { get; set; }
        public int Amt { get; set; }
        public int TranType { get; set; }
    }
}
