using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkActivityOOPS
{
   public class Dog : Animal
    {
        // this additional instance field is belongs to Derived class Cat
        private int _walkingProximity;
        public Dog(int id, string name, int walkingProximity) : base(id, name)
        {
            _walkingProximity = walkingProximity;
        }
    }
}
