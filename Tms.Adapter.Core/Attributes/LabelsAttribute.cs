using System;
using System.Collections.Generic;
using System.Linq;

namespace Tms.Adapter.Core.Attributes;

public class LabelsAttribute : Attribute, ITmsAttribute
{
    public List<string> Lables { get; }

    public LabelsAttribute(params string[] lables)
    {
        Lables = lables.ToList();
    }
}