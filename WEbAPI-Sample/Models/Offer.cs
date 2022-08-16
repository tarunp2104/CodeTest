using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbAPI_Sample.Models
{
    public class Offer
    {
        string offerName { get; set; }
        List<Product1> lstProducts { get; set; }
        Offer(string offerName,List<Product1> lstProducts)
        {
            this.offerName = offerName;
            this.lstProducts = lstProducts;
        }
    }
}
