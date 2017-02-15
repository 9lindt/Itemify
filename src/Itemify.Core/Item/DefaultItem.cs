﻿using System;
using Itemify.Core.ItemAccess;
using Itemify.Core.PostgreSql.Entities;
using Itemify.Core.Typing;

namespace Itemify.Core.Item
{
    class DefaultItem : ItemBase
    {
        public DefaultItem(Guid newGuid, TypeItem type, ItemContext context, IItemReference parent) 
            : base(context, new ItemEntity(), parent, true)
        {
            Guid = newGuid;
            Type = type;
        }

        public DefaultItem(ItemEntity entity, ItemContext context)
            : base(context, entity, new ItemReference(entity.ParentGuid, context.TypeManager.ParseTypeItem(entity.ParentType)), false)
        {
        }
    }
}
