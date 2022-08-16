using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbAPI_Sample.Models
{
    public class OfferService : IOfferService
    {
        public OfferService(Product1 invent)
        {
            insertInventory(invent);
        }
        private List<Product1> lstinventory = new List<Product1>();
        private void insertInventory(Product1 inventory)
        {
            lstinventory.Add(inventory);
        }
        public List<Product1> GetAllProducts()
        {
            return lstinventory;
        }
        //public List<Offer> GetTodaysOffers()
        //{
            
        //}
    }
}
