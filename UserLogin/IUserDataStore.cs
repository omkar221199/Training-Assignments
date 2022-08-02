using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDBLib
{
    internal interface IUserDataStore
    {
        bool ValidateUser(string Username, string Password);
    }
}
