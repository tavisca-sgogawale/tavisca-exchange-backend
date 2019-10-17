
using ERPBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class MockProductDatabase : IProductProvider
{
    public List<Product> _productList = new List<Product>()
        {
            new Product{Id=101,Name="Mobile", Price=new Price{ Amount=1299.00, IsNegotiable=true}, Category=Category.Mobiles,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="11 pro max 64 gb full box", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate = DateTime.Now, Status = Status.Active, UserId = "1118" },

            new Product{Id=102,Name="Bottle", Price=new Price{ Amount=999.00, IsNegotiable=true}, Category=Category.Others,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="Tavisca green color bottle", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate =  new DateTime(2019,12,1), Status = Status.Active, UserId = "1112" },

             new Product{Id=101,Name="Computer", Price=new Price{ Amount=11299.00, IsNegotiable=false}, Category=Category.Electronics,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="hp desktop", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate = DateTime.Now, Status = Status.Active, UserId = "1128" },

            new Product{Id=103,Name="Headphones", Price=new Price{ Amount=999.00, IsNegotiable=true}, Category=Category.Others,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="1 year used headphone", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate =  new DateTime(2019,12,1), Status = Status.Active, UserId = "1748" },

             new Product{Id=104,Name="Watch", Price=new Price{ Amount=1299.00, IsNegotiable=true}, Category=Category.Fashions,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="rolex watch", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate = DateTime.Now, Status = Status.Active, UserId = "918" },

            new Product{Id=105,Name="Car", Price=new Price{ Amount=93399.00, IsNegotiable=true}, Category=Category.Others,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="Old maruti 800", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate =  new DateTime(2019,12,1), Status = Status.Active, UserId = "653" },

             new Product{Id=106,Name="Bike", Price=new Price{ Amount=1299.00, IsNegotiable=true}, Category=Category.Bikes,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="4 year used R15", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate = DateTime.Now, Status = Status.Active, UserId = "1768" },

            new Product{Id=107,Name="Sofa", Price=new Price{ Amount=999.00, IsNegotiable=true}, Category=Category.Furniture,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="5 year old sofa", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate =  new DateTime(2019,12,1), Status = Status.Active, UserId = "118" },

             new Product{Id=108,Name="Bed", Price=new Price{ Amount=1299.00, IsNegotiable=true}, Category=Category.Furniture,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="1 year used bed", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate = DateTime.Now, Status = Status.Active, UserId = "1118" },

            new Product{Id=109,Name="Washing Mechine", Price=new Price{ Amount=999.00, IsNegotiable=true}, Category=Category.Electronics,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="LG washing mechine", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate =  new DateTime(2019,12,1), Status = Status.Active, UserId = "138" },

             new Product{Id=110,Name="TV", Price=new Price{ Amount=1299.00, IsNegotiable=true}, Category=Category.Electronics,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="Samsung 45' tv", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate = DateTime.Now, Status = Status.Active, UserId = "875" },

            new Product{Id=111,Name="Pendrive", Price=new Price{ Amount=999.00, IsNegotiable=true}, Category=Category.Others,
                HeroImage =new Image{Url = "https://www.olx.in/item/11-pro-max-64-gb-full-box-iid-1540782056/gallery"},
                Description ="Sandiscs 32 gb pen drive", Images=null,
                PickupAddress =new Address{Line1="abc",Line2="xyz", City="Pune",State="Maharashtra", Pincode=411038 },
                PostDateTime =  new DateTime(2019,12,1), PurchasedDate =  new DateTime(2019,12,1), Status = Status.Active, UserId = "1118" }
        };
    public Product GetProductById(int Id)
    {
        Product product = _productList.Where(n => n.Id == Id).First();
        return product;
    }
    public List<Product> GetProductsByPage(int pageNumber, int pageSize)
    {
        int startIndex = (pageNumber - 1) * (pageSize);
        int endIndex = (pageNumber * pageSize) - 1;
        Console.WriteLine(pageNumber + " "+ pageSize);
        List<Product> newProductList=new List<Product>();
        for(int i=startIndex;i<=endIndex;i++ )
        {
            newProductList.Add(_productList[i]);
        }
        return newProductList;
     
        
    }
    public Product AddProduct(Product product)
    {
        product.PostDateTime = DateTime.Now;
        product.Status = Status.Active;
        _productList.Add(product);
        return _productList.Where(n => n.Id == product.Id).First();
    }

}