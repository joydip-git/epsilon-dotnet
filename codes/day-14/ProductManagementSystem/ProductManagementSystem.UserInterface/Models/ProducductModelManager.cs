using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProductManagementSystem.Container;
using ProductManagementSystem.BL.Contracts;
using ProductManagementSystem.BL.Implementation;
using ProductManagementSystem.Entities;

namespace ProductManagementSystem.UserInterface.Models
{
    public class ProductModelManager
    {
        IBusinessManager<Product> businessManager;
        public ProductModelManager()
        {
            businessManager = new IOCContainer().Create<IBusinessManager<Product>, ProductBusinessManager>();
        }
        public List<ProductViewModel> GetAllProductRecords()
        {
            List<ProductViewModel> productModels = null;
            try
            {
                var list = businessManager.FetchAll();
                if (list != null)
                {
                    ConvertProductToProductModel(list, out productModels);
                }
                return productModels;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AddProductRecord(ProductAddViewModel productAddViewModel)
        {
            try
            {
                ConvertModelToProduct(productAddViewModel, out Product product);
                return businessManager.Insert(product);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ConvertModelToProduct(ProductAddViewModel productAddViewModel, out Product product)
        {
            product = new Product
            {
                Price = productAddViewModel.Price,
                ProductId = productAddViewModel.Id,
                ProductName = productAddViewModel.Name,
                Description = productAddViewModel.Description
            };
        }

        private void ConvertProductToProductModel(List<Product> list, out List<ProductViewModel> productModels)
        {           
            productModels = list.Select(p => new ProductViewModel
            {
                Id = p.ProductId,
                Name = p.ProductName,
                Description = p.Description,
                Price = p.Price
            }).ToList<ProductViewModel>();
        }
    }
}
