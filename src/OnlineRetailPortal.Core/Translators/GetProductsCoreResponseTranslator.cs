﻿using OnlineRetailPortal.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineRetailPortal.Core
{
    public static class GetProductsCoreResponseTranslator
    {

        public static ProductsWithPageInitiation ToProductsWithPageInitiation(this GetProductsStoreResponse getProductResponse)
        {
            ProductsWithPageInitiation responce = new ProductsWithPageInitiation()
            {
                Products = getProductResponse.Products.Select(x => new Product(x.Price.ToEntity(), x.SellerId, x.Name)
                {
                    Id = x.Id,
                    HeroImage = new Image() { Url = x.HeroImage.Url },
                    PostDateTime = x.PostDateTime,                
                }).ToList(),
                PagingInfo = new PagingInfo()
                {
                    PageNumber = getProductResponse.PagingInfo.PageNumber,
                    PageSize = getProductResponse.PagingInfo.PageSize,
                   TotalPages = getProductResponse.PagingInfo.TotalPages
                }
            };
            return responce;
        }

    }
}