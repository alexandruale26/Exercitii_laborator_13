using System;
using Exercitii_laborator_13.Exceptions;


namespace Exercitii_laborator_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            POS pos = new POS();

            Guid idTemporar = Banca.Instance.CreazaCont();
            ContBancar Mihai = Banca.Instance.conturiCurente[idTemporar];

            idTemporar = Banca.Instance.CreazaCont();
            ContBancar Ionel = Banca.Instance.conturiCurente[idTemporar];

            idTemporar = Banca.Instance.CreazaCont();
            ContBancar Dana = Banca.Instance.conturiCurente[idTemporar];


            CardBancar card1Mihai = null;
            CardBancar card2Mihai = null;
            CardBancar card3Mihai = null;
            CardBancar card1Dana = null;


            try
            {
                card1Dana = Banca.Instance.EmiteCard(Dana.ID);

                card1Mihai = Banca.Instance.EmiteCard(Mihai.ID);
                card2Mihai = Banca.Instance.EmiteCard(Mihai.ID);
                card3Mihai = Banca.Instance.EmiteCard(Mihai.ID);
            }
            catch (AccountInvalidException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (CardLimitException e)
            {
                Console.WriteLine(e.Message);
            }


            Mihai.DepuneNumerar(10_000d);
            Dana.DepuneNumerar(500d);


            Banca.Instance.conturiCurente.Remove(Dana.ID);



            try
            {
                pos.Plateste(30000, card2Mihai);
            }
            catch (CardInvalidException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AccountInvalidException e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                pos.Plateste(3000, card1Mihai);
            }
            catch (CardInvalidException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AccountInvalidException e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                pos.Plateste(300, card1Dana);
            }
            catch (CardInvalidException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AccountInvalidException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
