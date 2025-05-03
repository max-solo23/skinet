using Core.Entities;

namespace Core.Specifications;

public class ProductSpecification : BaseSpecification<Product>
{
    public ProductSpecification(ProductSpecificationParams specificationParams) : base(x => 
        (specificationParams.Brands.Count == 0 || specificationParams.Brands.Contains(x.Brand)) &&
        (specificationParams.Types.Count == 0 || specificationParams.Types.Contains(x.Type))
    )
    {
        switch (specificationParams.Sort)
        {
            case "priceAsc":
                AddOrderBy(x => x.Price);
                break;
            case "priceDesc":
                AddOrderByDescending(x => x.Price);
                break;
            default:
                AddOrderBy(x => x.Name);
                break;
        }
    }

}
