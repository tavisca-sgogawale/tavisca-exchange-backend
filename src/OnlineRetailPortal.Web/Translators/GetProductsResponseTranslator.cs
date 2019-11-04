﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRetailPortal.Web
{
    public static class GetProductsResponseTranslator
    {
        public static GetProductsResponse ToGetProductsContract(this Contracts.GetProductsServiceResponse getProductsServiceResponse)
        {
            GetProductsResponse response = new GetProductsResponse()
            {
                Products = getProductsServiceResponse.Products.Select(x => new Product()
                {
                    Name = x.Name,
                    Id = x.Id,
                    HeroImage = new Image() { Url = x.HeroImage.Url },
                    ExpirationDate = x.ExpirationDate,
                    PostDateTime = x.PostDateTime,
                    Description = x.Description,
                    Price = new Price() { Amount = x.Price.Amount, IsNegotiable = x.Price.IsNegotiable },
                    PurchasedDate = x.PurchasedDate,
                    PickupAddress = new Web.Address()
                    {
                        City = x.PickupAddress.City,
                        State = x.PickupAddress.State,
                        Line1 = x.PickupAddress.Line1,
                        Line2 = x.PickupAddress.Line2,
                        Pincode = x.PickupAddress.Pincode
                    },
                    Images = x.Images.Select(y => new Web.Image
                    {
                        Url = y.Url
                    }).ToList(),
                    Status = (Status)x.Status.GetHashCode(),
                    Category = (Category)x.Category.GetHashCode()
                }).ToList(),
                PagingInfo = new PagingInfo()
                {
                    PageNumber = getProductsServiceResponse.PagingInfo.PageNumber,
                    PageSize = getProductsServiceResponse.PagingInfo.PageSize,
                    SortBy = (SortBy)getProductsServiceResponse.PagingInfo.SortBy

                }
            };
            return response;
        }
    }
}