﻿using System;

namespace roundhouse.tests
{
    public abstract class TinySpec<T>: TinySpec
    {
        protected abstract T sut { get; set; }
    }

    public class ConcernAttribute : ConcernForAttribute
    {
        public ConcernAttribute(Type type) : base(type.Name)
        {}
    }
}
