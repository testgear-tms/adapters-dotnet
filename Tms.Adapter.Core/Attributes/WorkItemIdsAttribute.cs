using System;
using System.Collections.Generic;
using System.Linq;

namespace Tms.Adapter.Core.Attributes;

public class WorkItemIdsAttribute : Attribute, ITmsAttribute
{
    public List<string> Ids { get; }

    public WorkItemIdsAttribute(params string[] ids)
    {
        Ids = ids.ToList();
    }
}