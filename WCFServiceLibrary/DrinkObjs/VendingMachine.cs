using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WCFServiceLibrary.DrinkObjs
{
    [DataContract]
    public class VendingMachine
    {
        [DataMember]
        public double totalAmoun { get; set; }
        [DataMember]
        public List<Drink> drinks { get; set; }
        [DataMember]
        public int operationsMade { get; set; }

        public VendingMachine(double amount, List<Drink> drinks, int operationsMade)
        {
            this.totalAmoun = amount;
            this.drinks = drinks;
            this.operationsMade = operationsMade;

        }


        internal void SetDrinks(List<Drink> drinks)
        {
            this.drinks = drinks;
        }

        internal void DeleteDrinks()
        {
            SetDrinks(new List<Drink>());

        }

        internal void Reset() 
        {
            DeleteDrinks();
            totalAmoun = 0;
            operationsMade = 0;
        }

        internal string SellDrink(string drinkName)
        {
            Drink drinkToSell = drinks.FirstOrDefault(d => d.name.ToLower() == drinkName.ToLower());

            if (drinkToSell != null)
            {
                totalAmoun += drinkToSell.cost;
                operationsMade++;
                drinkToSell.count--;
                if (drinkToSell.count == 0) drinks.Remove(drinkToSell);
                return string.Format("{0} sold.", drinkName);
            }
            return string.Format("There's no {0} to sell",drinkName);
        }

        internal string AddDrink(Drink drink) 
        {
            string feedBack;
            Drink current = drinks.FirstOrDefault(d => d.name.ToLower() == drink.name.ToLower() && d.cost == drink.cost);
            if(current != null) 
            {
                current.count += drink.count;
                feedBack = string.Format("Added {0} to {1}",drink.count, drink.name);
            }
            else 
            {
                drinks.Add(drink);
                feedBack = string.Format("New drinks Added {0} {1} with cost of {2}",drink.count, drink.name,drink.cost);
            }
            return feedBack;
        }

    }
}



