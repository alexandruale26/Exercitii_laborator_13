using System;
using System.Collections.Generic;
using System.Text;


namespace Exercitii_laborator_13
{
    class POS
    {
        public void Plateste(double sumaDePlata, CardBancar card)
        {
            card.IntroduCard();
            Guid currentID = card.GetCardData();
            
            try
            {
                Banca.Instance.Plateste(sumaDePlata, currentID);
            }
            finally
            {
                card.ExtrageCard();
            }
        }
    }
}
