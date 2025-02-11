﻿using BuilderPattern.Examples.Metanit.Abstractions;

namespace BuilderPattern.Examples.Metanit.Entity
{
    class Baker
    {
        public Bread Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();
            breadBuilder.SetFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();
            return breadBuilder.Bread;
        }
    }
}
