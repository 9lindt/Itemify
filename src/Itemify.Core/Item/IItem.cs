﻿using System;
using System.Collections.Generic;
using Itemify.Core.Typing;

namespace Itemify.Core.Item
{
    public interface IItem : IItemReference
    {
        TypeSet SubTypes { get; }
        DateTime Created { get; }
        DateTime Modified { get; }
        int Revision { get; }
        bool Debug { get; }
        bool HasBody { get; }
        bool IsNew { get; }
        bool IsParentResolved { get; }
        IItemReference Parent { get; }
        IReadOnlyCollection<IItemReference> Children { get; }
        IReadOnlyCollection<IItemReference> Related { get; }
        Guid Guid { get; }
        TypeItem Type { get; }
        string Name { get; set; }
        double? ValueNumber { get; set; }
        DateTime? ValueDate { get; set; }
        string ValueString { get; set; }
        int Order { get; set; }
        T GetBody<T>();
        T TryGetBody<T>();
        void SetBody(object body);
        void SetBody(object body, bool beatify);
    }
}