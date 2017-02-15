﻿using System;

namespace Itemify.Core.Typing
{
    public class TypeDefinitionAttribute : Attribute
    {
        public string Name { get; }

        public TypeDefinitionAttribute(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            Name = name;
        }
    }
}
