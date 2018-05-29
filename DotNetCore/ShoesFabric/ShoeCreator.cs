﻿namespace ShoesFabric
{
    public abstract class ShoeCreator : IShoeCreator
    {
        public abstract StreetShoe CreateShoe();

        public abstract Sandal CreateSandal();
    }
}
