using System;
using System.Collections.Generic;
using Exercitii_laborator_13.Exceptions;


namespace Exercitii_laborator_13
{
    public sealed class Banca
    {
        private static readonly Banca _instance = new Banca();
        public static Banca Instance { get { return _instance; } }

        public Dictionary<Guid, ContBancar> conturiCurente = new Dictionary<Guid, ContBancar>();

        /// <summary>
        /// Card ID / Account ID
        /// </summary>
        public Dictionary<Guid, Guid> carduriActive = new Dictionary<Guid, Guid>();
        

        public Guid CreazaCont()
        {
            ContBancar contNou = new ContBancar();

            this.conturiCurente.Add(contNou.ID, contNou);
            return contNou.ID;
        }


        public CardBancar EmiteCard(Guid idCont)
        {
            if (!conturiCurente.ContainsKey(idCont))
            {
                throw new AccountInvalidException();
            }

            if (conturiCurente[idCont].totalCarduriEmise >= 2)
            {
                throw new CardLimitException();
            }

            CardBancar cardNou = new CardBancar();
            carduriActive.Add(cardNou.ID, idCont);

            conturiCurente[idCont].totalCarduriEmise++;

            return cardNou;
        }


        public void Plateste(double sumaDePlata, Guid cardID)
        {
            if (!carduriActive.ContainsKey(cardID))
            {
                throw new CardInvalidException();
            }

            if (!conturiCurente.ContainsKey(carduriActive[cardID]))
            {
                throw new AccountInvalidException();
            }

            try
            {
                conturiCurente[carduriActive[cardID]].ExtrageNumerar(sumaDePlata);
            }
            catch (WithdrawalException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
