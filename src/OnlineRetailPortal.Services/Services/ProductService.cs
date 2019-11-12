﻿using OnlineRetailPortal.Contracts;
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

        public async Task<GetProductServiceResponse> GetProductAsync(string productId)
        {
            var response = await Core.Product.GetAsync(productId, _productStore);
            return response.ToServiceModel();
        }

        public async Task<GetProductsServiceResponse> GetProductsAsync(GetProductsServiceRequest request)
        {
            var response = await Core.Product.GetProductsAsync(request, _productStore);
            return response.ToModel();
        }

        public async Task<UpdateProductEntity> UpdateProductAsync(UpdateProductEntity updateProductEntity)
        {
            Core.Product product = updateProductEntity.ToEntity();
            var response = await product.UpdateAsync(_productStore);
            return response.ToResponseModel();
        }
    }
}
