﻿using Microsoft.AspNetCore.Mvc;
using Team6.Data;
using Team6.Models;

namespace Team6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //return view of the individual product based on product Id or name
            return View();
        }


        


        public IActionResult CreateReview(string? submitReviewButton, int? ratingStars, string? reviewDescription, int OrderItemId) 
        {
            //when "submit" button page is clicked on the create review page
            if (submitReviewButton == null)
            {
                return View();
            }
            else
            {
                //test sample update
                OrderItemId = 20081;
                ProductData.submitReview(ratingStars, reviewDescription, OrderItemId);
                return View();
                // return RedirectToAction("ProductReview");
            }
        }
    }
}
