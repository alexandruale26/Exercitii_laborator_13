using System;


namespace Exercitii_laborator_13.Exceptions
{
    class CardInvalidException : Exception
    {
        public CardInvalidException() : base("Nu exista cardul cu acest ID")
        {
        }
    }
}
