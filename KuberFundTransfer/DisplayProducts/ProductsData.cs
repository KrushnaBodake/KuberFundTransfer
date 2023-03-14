using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.DisplayProducts
{
    public class ProductsDat
    {
        private List<ProductInfo> productInfos = new List<ProductInfo>();

        public ProductsDat()
        {
            productInfos = new List<ProductInfo>();
        }

        public void AddProducts(ProductInfo product)
        {
            productInfos.Add(product);
        }

        public void UpdateProduct(ProductInfo prod)
        {
            foreach (ProductInfo item in productInfos)
            {
                if(item.ProductNo==prod.ProductNo)
                {
                    item.ProductName = prod.ProductName;
                    item.BrandName = prod.BrandName;
                    
                    item.ProductPrice = prod.ProductPrice;
                    break;
                }
            }
        }
        public void DeleteProduct(int no)
        {
            foreach (ProductInfo item in productInfos)
            {
                if(item.ProductNo==no)
                {
                    productInfos.Remove(item);
                    break;
                }
                
            }           
        }
        public List<ProductInfo> CheckPrice()
        {
            List<ProductInfo> productInfos1 = new List<ProductInfo>();
            foreach (ProductInfo item in productInfos)
            {
                if(item.ProductPrice>1000 && item.ProductPrice < 2000)
                {
                    productInfos1.Add(item);
                }
            }
            return productInfos1;
        }
       
        public List<ProductInfo> ListProduct()
        {
            return productInfos;
        }
    }
}
