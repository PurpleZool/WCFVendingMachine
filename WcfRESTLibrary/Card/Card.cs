using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfRESTLibrary.Card
{
    public class Card
    {
        public string ownerName { get; set;}
        public string cardNumber { get; set;}
        public bool isActive { get; set; }

        public Card() 
        {
            
            
        
        }

        public Card(string ownerName, string cardNumber) 
        {
            this.ownerName = ownerName;
            this.cardNumber = cardNumber;
        }
    }
}
