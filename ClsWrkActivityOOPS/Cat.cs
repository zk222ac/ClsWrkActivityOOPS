using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkActivityOOPS
{
    // Derived class is Cat
    // Base class is Animal
    // : we are implementing inheritance 
    // code resusability 
    public class Cat : Animal
    {
        // this additional instance field is belongs to Derived class Cat
        private int _walkingProximity;
        public Cat(int id, string name , int walkingProximity) : base(id, name)
        {
            _walkingProximity = walkingProximity;
        }


    }
}
