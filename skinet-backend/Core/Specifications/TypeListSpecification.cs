using System;
using skinet.Core.Entities;

namespace skinet.Core.Specifications;

public class TypeListSpecification : BaseSpecification<Product, string>
{

    public TypeListSpecification()
    {
        AddSelect(x => x.Type);
        ApplyDistinct();
    }
}
