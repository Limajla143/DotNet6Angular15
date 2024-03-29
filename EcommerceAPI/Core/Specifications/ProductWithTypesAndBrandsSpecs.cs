﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductWithTypesAndBrandsSpecs : BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandsSpecs(ProductSpecParams productSpecParams)
            : base(x => 
            (string.IsNullOrEmpty(productSpecParams.Search) || x.Name.ToLower().Contains(productSpecParams.Search)) &&
            (!productSpecParams.BrandId.HasValue || x.ProductBrandId == productSpecParams.BrandId) && 
            (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId))
        {
            AddInclude(x => x.ProductType);
            AddInclude(y => y.ProductBrand);
            AddOrderBy(x => x.Name);
            ApplyPaging(productSpecParams.PageSize * (productSpecParams.PageIndex - 1), productSpecParams.PageSize);

            if(!string.IsNullOrEmpty(productSpecParams.Sort))
            {
                switch(productSpecParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
;       }

        public ProductWithTypesAndBrandsSpecs(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(y => y.ProductBrand);
        }
    }
}
