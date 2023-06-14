using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRESTLibrary
{
    public class CardService : ICardService
    {

        private List<Card.Card> cardsCache = new List<Card.Card>() 
        {
            new Card.Card("Luis", "2"),
            new Card.Card("Juan", "3"),
            new Card.Card("Paco", "12"),
        };


        public string GetData(string value)
        {
            Card.Card selectedCard = cardsCache.FirstOrDefault(c => c.cardNumber == value);
            if(selectedCard != null) 
            {
                return string.Format("Card found: {0} :: {1} :: Active {2}", selectedCard.ownerName, selectedCard.cardNumber, selectedCard.isActive);
            }
            return string.Format("You entered: {0}", value);
        }

    }
}
