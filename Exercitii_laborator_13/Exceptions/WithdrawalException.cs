using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitii_laborator_13.Exceptions
{
    class WithdrawalException : Exception
    {
        public WithdrawalException() : base("Suma dorita depaseste soldul")
        {
        }
    }
}
