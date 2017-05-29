﻿namespace PipeliningLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // A specifier that encapsulates a type (to be instantiated) of a IPipe.
    internal class PipeTypeSpecifier : IPipeSpecifier
    {
        // Encapsulated type (to be instantiated).
        private readonly Type _type;

        // Ctor accepting the type to be encapsulated.
        public PipeTypeSpecifier(Type type)
        {
            _type = type;
        }

        // Resolves this specifier returning an instance of the encapsulated type.
        public IEnumerable<IBasePipe> Resolve()
        {
            if (!typeof(IBasePipe).IsAssignableFrom(_type))
            {
                Trace.UnexpectedType(_type);
                return Enumerable.Empty<IBasePipe>();
            }

            return new[] { (IBasePipe)Activator.CreateInstance(_type) };
        }
    }
}
