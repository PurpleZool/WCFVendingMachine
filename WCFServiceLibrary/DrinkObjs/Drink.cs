using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceLibrary.DrinkObjs
{
    [DataContract]
    public class Drink
    {
        [DataMember]
        public string name = "drink";
        [DataMember]
        public double cost = 0;
        [DataMember]
        public int count = 0;
        
        public Drink() { }

        public Drink(string name, double cost, int count) 
        {
            this.name = name;
            this.cost = cost;
            this.count = count;
        }

        public string ToSave() 
        {
            return string.Format("{0}%{1}%{2}", name, cost, count);
        }
    }
}
