﻿using asp.net_core_basic.Models;
using Microsoft.AspNetCore.Mvc;
namespace asp.net_core_basic.Controllers

{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            List<Product> product = new List<Product>();

            var pro1 = new Product()
            {
                Name = "product name 1",
                Id = 1,
                Data = new Data()
                {
                    CustomerName = "Mehmet",
                    CustomerAge = 24
                }
            };
            product.Add(pro1);

            var pro2 = new Product()
            {
                Name = "product name 2",
                Id = 2,
                Data = new Data()
                {
                    CustomerName = "Ali",
                    CustomerAge = 25
                }
            };
            product.Add(pro2);

            var pro3 = new Product()
            {
                Name = "product name 3",
                Id = 3,
                Data = new Data()
                {
                    CustomerName = "Büber",
                    CustomerAge = 26
                }
            };
            product.Add(pro3);
            var pro4 = new Product()
            {
                Name = "product name 4",
                Id = 4,
                Data = new Data()
                {
                    CustomerName = "Barış",
                    CustomerAge = 18
                }
            };
            product.Add(pro4);
            var pro5 = new Product()
            {
                Name = "product name 5",
                Id = 5,
                Data = new Data()
                {
                    CustomerName = "Ramazan",
                    CustomerAge = 25
                }
            };
            product.Add(pro5);

            // getMessage() metodu çağrılarak mesajı al
            string message = getMessage("okkey");

            // ViewModel oluşturup verileri ata 
            var viewModel = new ProductPageViewModel
            {
                Products = product,
                Message = message
            };

            return View(viewModel);
        }

        public string getMessage(string msg)
        {
            string message;
            if (msg == "ok")
            {
                message = "mesajınız bu!";
            }
            else
            {
                message = "hata";
            }

            return message;
        }
    }
}
