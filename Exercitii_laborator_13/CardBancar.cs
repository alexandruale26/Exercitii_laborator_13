using System;


namespace Exercitii_laborator_13
{
    public class CardBancar
    {
        public Guid ID { get; private set; }


        public CardBancar()
        {
            this.ID = Guid.NewGuid();
        }


        public void IntroduCard()
        {
            Console.WriteLine("Cardul a fost introdus");
        }


        public Guid GetCardData()
        {
            return this.ID;
        }


        public void ExtrageCard()
        {
            Console.WriteLine("Cardul a fost extras");
        }
    }
}
