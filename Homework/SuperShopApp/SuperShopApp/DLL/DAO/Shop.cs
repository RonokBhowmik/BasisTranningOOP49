using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp.DLL.DAO
{
   public class Shop
    {

       public string ShopId { get; set; }

       public string ShopName { get; set; }

       public string ShopAddress { get; set; }

      public List<Product> Products=new List<Product>(); 

       public Shop(string shopName,string shopAddress):this()
       {
           this.ShopName = shopName;
           this.ShopAddress = shopAddress;
       }

       public Shop()
       {

       }

       public string Add(Product aProduct)
       {
           if (HasThisProduct(aProduct.ProductId))
           {
               UpdateProduct(aProduct);
           }
           Products.Add(aProduct);
           return "Product Added";
       }

       private void UpdateProduct(Product aProduct)
       {
           foreach (var product in Products)
           {
               if (aProduct.ProductId == product.ProductId)
               {
                   product.ProductQuantity += aProduct.ProductQuantity;
               }
           }
       }

       public bool HasThisProduct(int productId)
       {
           foreach (var product in Products)
           {
               if (product.ProductId==productId)
               {
                   return true;
               }
           }
           return false;
       }
    }
}
