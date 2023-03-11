using DISample.Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Service
{
    public class BetterService : IProductService
    {
        // TODO: Execute implement GetAll() method from IProductService
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel(){Id = 1, Name="Product 1"},
                new ProductViewModel(){Id = 2, Name="Product 2"},
                new ProductViewModel(){Id = 3, Name="Product 3"},
                new ProductViewModel(){Id = 4, Name="Product 4"},
                new ProductViewModel(){Id = 5, Name="Product 5"}
            };
        }
    }
}
