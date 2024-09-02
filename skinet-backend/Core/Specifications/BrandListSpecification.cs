using System;
using skinet.Core.Entities;

namespace skinet.Core.Specifications;

public class BrandListSpecification : BaseSpecification<Product, string>
{
    public BrandListSpecification()
    {
        AddSelect(x => x.Brand);
        ApplyDistinct();
    }

}
