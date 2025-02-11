﻿using BuilderPattern.Examples.Metanit.Entity;

namespace BuilderPattern.Examples.Metanit.Abstractions
{
    abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }
        public void CreateBread()
        {
            Bread = new Bread();
        }
        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }
}
