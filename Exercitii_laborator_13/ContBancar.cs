using System;
using Exercitii_laborator_13.Exceptions;


namespace Exercitii_laborator_13
{
    public class ContBancar
    {
        public Guid ID { get; private set; }
        public int totalCarduriEmise = 0;
        private double sold = 0.0d;


        public ContBancar()
        {
            this.ID = Guid.NewGuid();
        }


        public void DepuneNumerar(double sumaDepusa)
        {
            this.sold += sumaDepusa;
        }


        public void ExtrageNumerar(double sumaDeExtras)
        {
            if (this.sold < sumaDeExtras)
            {
                throw new WithdrawalException();
            }

            this.sold -= sumaDeExtras;
            Console.WriteLine("Plata a fost efectuata");
        }
    }
}
