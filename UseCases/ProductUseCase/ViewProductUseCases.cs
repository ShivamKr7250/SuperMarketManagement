﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductUseCase
{
    public class ViewProductUseCases : IViewProductUseCases
    {
        private readonly IProductRepository productRepository;

        public ViewProductUseCases(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return productRepository.GetProducts();
        }
    }
}
