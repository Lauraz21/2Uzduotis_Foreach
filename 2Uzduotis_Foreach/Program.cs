namespace _2Uzduotis_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cardType = { "Clubs", "Spades", "Hearths", "Diamonds" };
            string[] cardNumber = {"6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            string[] cardsDeck = CardDeck(cardType, cardNumber);
          
            foreach (string card in cardsDeck)
            {
                Console.WriteLine(card);
            }
        }
        public static string[] CardDeck(string[] cardNumber, string[] cardType)
        {
            string[] newCards = new string[cardType.Length * cardNumber.Length];
            int index = 0;
            foreach (string type in cardType)
            { 
                foreach (string item in cardNumber)
                {
                    newCards[index++] = item + type;
                }
            }
            return newCards;
        }
        
    }
}