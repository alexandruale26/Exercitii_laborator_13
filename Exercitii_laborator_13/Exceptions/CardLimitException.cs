using System;

namespace Exercitii_laborator_13.Exceptions
{
    class CardLimitException : Exception
    {
        public CardLimitException() : base("Nu se poate genera un alt card. Limita maxima a fost atinsa")
        {
        }
    }
}
