using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceLibrary.DrinkObjs;

namespace WCFServiceLibrary
{
    [ServiceContract]
    public interface IMainService
    {
        [OperationContract]
        List<Drink> GetDrinks();
        [OperationContract]
        void SetDrinks(List<Drink> newDrinks);
        [OperationContract]
        void DeleteDrinks();
        [OperationContract]
        string SetCash(double newCash);
        [OperationContract]
        void ResetMachine();
        [OperationContract]
        VendingMachine GetVendingObj();
        [OperationContract]
        string GetStatus();
        [OperationContract]
        string SellDrink(string drinkName);
        [OperationContract]
        string AddDrink(Drink drink);

    }
}
