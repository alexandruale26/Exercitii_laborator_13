using System;

namespace Exercitii_laborator_13.Exceptions
{
    internal class AccountInvalidException : Exception
    {
        public AccountInvalidException() : base("Contul nu exista in baza de date")
        {
        }
    }
}
