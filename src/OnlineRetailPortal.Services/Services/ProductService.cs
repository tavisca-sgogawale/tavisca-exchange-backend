﻿using OnlineRetailPortal.Contracts;
using System;
using System.Threading.Tasks;

namespace OnlineRetailPortal.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductStoreFactory _productStoreFactory;
        private readonly IProductStore _productStore;
        public ProductService(IProductStoreFactory productStoreFactory)
        {
            this._productStoreFactory = productStoreFactory;
            _productStore = _productStoreFactory.GetProductStore();
        }

        public async Task<AddProductResponse> AddProductAsync(AddProductRequest addProductRequest)
        {
            var config = new ProductConfiguration()
            {
                ExpiryInDays = 30
            };
            Core.Product product = addProductRequest.ToEntity();
            Core.Product response = await product.SaveAsync(_productStore, config);
            return response.ToModel();
        }

        public Task<GetProductServiceResponse> GetProductAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public async Task<GetProductsServiceResponse> GetProductsAsync(GetProductsServiceRequest request)
        {
            var response = await Core.Product.GetProductsAsync(request, _productStore);
            return response.ToModel();
        }
    }
}
