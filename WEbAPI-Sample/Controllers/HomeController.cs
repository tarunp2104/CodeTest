using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEbAPI_Sample.Models;

namespace WEbAPI_Sample.Controllers
{
    [Route("Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //[HttpGet]
        //[Route("GetOrders")]
        //public List<Order> GetOrders()
        //{
        //    SampleDBContext _context = new SampleDBContext();
        //    var orders = _context.Orders.ToList();
        //    return orders;
        //}
        private OfferService _offer;
        public HomeController(OfferService offer)
        {
            _offer = offer;
        }
        [HttpGet]
        [Route("GetAllProducts")]
        public List<Product1> GetAllProducts()
        {
            List<Product1> lstproducts = _offer.GetAllProducts();
            // lstproducts.Sort(x => x.price);
            return lstproducts;
        }
        [HttpGet]
        [Route("GetSecondLoweset")]
        public Product1 Getsecondlowest()
        {
            List<Product1> lstproducts = _offer.GetAllProducts();
            //lstproducts.Where(x => x.price);
            List<decimal> lstprice = new List<decimal>();
            foreach(var prod in lstproducts)
            {
                lstprice.Add(prod.price);
            }
            lstprice.Sort();
            return lstproducts.Where(x=>x.price == lstprice[1]).FirstOrDefault();
        }
        [HttpPost]
        [Route("InsertProduct")]
        public void InsertProduct(Product1 prod)
        {
            OfferService off=new OfferService(prod);
            
        }
         
    }
}
