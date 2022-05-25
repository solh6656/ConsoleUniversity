using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Nwe_Version.IRepositories
{
    internal interface IFunctionsRepository
    {
        void SingUp();
        bool Login();
        string HashingPassword(string password);

    }
}
