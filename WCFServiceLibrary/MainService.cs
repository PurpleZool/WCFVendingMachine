using System.Collections.Generic;
using System.IO;
using System.Text;
using WCFServiceLibrary.DrinkObjs;
using System.Linq;

namespace WCFServiceLibrary
{
    public class MainService : IMainService
    {
        private static string someFreeFolder = @"C:\FreeFolder";
        private static string savePath = Path.Combine(someFreeFolder,"machineSave.txt");

        #region CONTRACT METHODS

        public string GetHtml() 
        {
            string html = "<!DOCTYPE html><html><head><title>VendingService</title></head><body><h1>VendingService</h1>" +
                "<p>A WCF service that simulates a 24/7 vending machine for beverages.</p>" +
                "<h2>Available Functions</h2>" +
                "<ul><li><strong>GetHtml()</strong>: Gets the HTML text of the page.</li>" +
                "<li><strong>GetDrinks()</strong>: Gets the list of available drinks.</li>" +
                "<li><strong>SetDrinks(List&lt;Drink&gt; newDrinks)</strong>: Sets the list of available drinks.</li>" +
                "<li><strong>DeleteDrinks()</strong>: Deletes all drinks from the machine.</li>" +
                "<li><strong>SetCash(double newCash)</strong>: Sets the available cash in the machine.</li>" +
                "<li><strong>ResetMachine()</strong>: Resets the machine to its initial state.</li>" +
                "<li><strong>GetVendingObj()</strong>: Gets the current VendingMachine object.</li>" +
                "<li><strong>GetStatus()</strong>: Gets the current status of the machine.</li>" +
                "<li><strong>SellDrink(string drinkName)</strong>: Sells a specific drink by its name.</li>" +
                "<li><strong>AddDrink(Drink drink)</strong>: Adds a new drink to the machine.</li></ul></body></html>";
            return html;
        }



        public List<Drink> GetDrinks()
        {
            return ReadData().drinks;
        }
        public void SetDrinks(List<Drink> newDrinks)
        {
        }
        public void DeleteDrinks() 
        {
            VendingMachine vendor = ReadData();
            vendor.DeleteDrinks();
            SaveData(vendor);
        }

        public string SetCash(double newCash) 
        {
            VendingMachine vendor = GetVendingObj();
            vendor.totalAmoun = newCash;
            SaveData(vendor);
            return string.Format("New cash set to {0}", newCash);
        }

        public void ResetMachine()
        {
            VendingMachine vendor = ReadData();
            vendor.Reset();
            SaveData(vendor);
        }

        public VendingMachine GetVendingObj() 
        {
            return ReadData();
        }

        public string GetStatus() 
        {
            VendingMachine vendor = ReadData();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("CASH = {0}\nOPERATIONS MADE = {1}", vendor.totalAmoun,vendor.operationsMade));
            return sb.ToString();
        }

        public string SellDrink(string drinkName) 
        {
            string feedBack;
            VendingMachine vendor = ReadData();
            feedBack = vendor.SellDrink(drinkName);
            SaveData(vendor);
            return feedBack;
        }
        public string AddDrink(Drink drink)
        {
            string feedBack;
            VendingMachine vending = ReadData();
            feedBack = vending.AddDrink(drink);
            SaveData(vending);
            return feedBack;
        }
        #endregion

        #region DATA MANAGE
        internal VendingMachine ReadData() 
        {
            CheckSave();

            string[] lines = File.ReadAllLines(savePath);
            List<Drink> drinks = new List<Drink>();
            double currentCost;
            int quantity,operationsMade;

            double totalAmount;
            double.TryParse(lines[0].Split('%')[0], out totalAmount);
            int.TryParse(lines[0].Split('%')[1], out operationsMade);

            for(int i=1; i<lines.Length; i++) 
            {
                Drink currentDrink = new Drink();
                string[] splitted = lines[i].Split('%');
                currentDrink.name = splitted[0];
                double.TryParse(splitted[1], out currentCost);
                int.TryParse(splitted[2], out quantity);
                currentDrink.cost = currentCost;
                currentDrink.count = quantity;
                drinks.Add(currentDrink);
            }
            return new VendingMachine(totalAmount, drinks, operationsMade);
        }
        internal void SaveData( VendingMachine vendor) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}%{1}", vendor.totalAmoun.ToString(), vendor.operationsMade.ToString()));
            foreach(Drink drink in vendor.drinks) 
            {
                sb.AppendLine(drink.ToSave());
            }

            File.WriteAllText(savePath, sb.ToString());
        }
        internal void CheckSave() 
        {
            if (!File.Exists(savePath)) 
            {
                if (!Directory.Exists(someFreeFolder)) Directory.CreateDirectory(someFreeFolder);
                InitializeSave();
            }    
        }
        internal void InitializeSave() 
        {
            string initText = "26,12%10\nCoffee%1,25%10\nBeer%1,40%28\n";
            File.WriteAllText(savePath, initText);
        }
        #endregion

    }
}
