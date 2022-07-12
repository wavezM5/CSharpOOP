﻿namespace Animals
{
    using System;
    public class Dog : Animal
    {
        public Dog(string name, string favFood) : base(name, favFood)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";
        }
    }
}