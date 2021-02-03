using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkActivityOOPS
{
    // Base class
   public class Animal
    {
       
        private int _Id;
        private string _name;

        public Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Animal()
        {

        }        

        public int Id { get => _Id; set => _Id = value; }
        public string Name { get => _name; set => _name = value; }

        public string Sleeping()
        {
            return $"Every animal has sleeping habit";
        }
        public string Noise()
        {
            return $"Every animal make a noise";
        }

    }
}
