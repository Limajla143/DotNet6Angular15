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
        public ProductWithTypesAndBrandsSpecs(string sort, int? brandId, int? typeId)
            : base(x => (!brandId.HasValue || x.ProductBrandId == brandId) && (!typeId.HasValue || x.ProductTypeId == typeId))
        {
            AddInclude(x => x.ProductType);
            AddInclude(y => y.ProductBrand);
            AddOrderBy(x => x.Name);

            if(!string.IsNullOrEmpty(sort))
            {
                switch(sort)
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
