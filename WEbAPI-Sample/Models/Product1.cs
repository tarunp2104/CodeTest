using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbAPI_Sample.Models
{
    public class Product1
    {
       public string productnName { get; set; }
        public decimal price { get; set; }
       public string description { get; set; }
        Product1(string productName,decimal price,string description)
        {
            this.productnName = productnName;
            this.price = price;
            this.description = description;
        }
    }
}
