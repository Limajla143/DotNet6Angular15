using Core.Entities;
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
        public ProductWithTypesAndBrandsSpecs()
        {
            AddInclude(x => x.ProductType);
            AddInclude(y => y.ProductBrand);
;       }

        public ProductWithTypesAndBrandsSpecs(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(y => y.ProductBrand);
        }
    }
}
