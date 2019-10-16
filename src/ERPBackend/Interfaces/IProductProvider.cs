﻿using ERPBackend.Models;
using System.Collections.Generic;

public interface IProductProvider
{
    List<Product> GetProductsByPage(int pageNumber, int pageSize);
    Product GetProductById(string Id);
    Product AddProduct(Product product);
}