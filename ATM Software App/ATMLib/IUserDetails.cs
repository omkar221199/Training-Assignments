using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
    public interface IUserDetails
    {
        int VaildateUser(string cardno, string pin);
    }
}
