using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
    public class User
    {
        public int UserID { get; set; }
        public string CardNo { get; set; }
        public string Pin { get; set; }
        public double AccBal { get; set; }
    }
}
