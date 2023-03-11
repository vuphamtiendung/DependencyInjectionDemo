using DISample.Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Service
{
    public class ProductService : IProductService
    {
        // TODO: Execute implement GetAll() method from IProductService
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel(){Id = 1, Name="Pen Drive"},
                new ProductViewModel(){Id = 2, Name="Memory card"},
                new ProductViewModel(){Id = 3, Name="Mobile phone"},
                new ProductViewModel(){Id = 4, Name="Tablet"},
                new ProductViewModel(){Id = 5, Name="Desktop PC"}
            };
        }

    }
}
