using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkActivityOOPS
{
    // access modifiers 
    // public , private , protected , internal 
    // Public --> accesiible for ALL
    // Private --> outside the class memebers can not use it if it is assume to be a private
    // protected --> directly in the derived ( use only when you use inheritance mechanism) 
    // internal --> access the data members from outside the project or another project
    // bydefault when you create class , it has by private access modifier
     class Car
    {
        // 1 - Instance field 
        // 2- Properties
        // 3 - Constructor - special method 
        // 4 - Methods - Normal method

        // is a simple variable which hold the values for internal purpose 
        // encapsulation -- information hiding - hide the information from outde access 
        #region Instance field

        private int _id;
        private string _model;
        private string _year;
        private string _color;

        #endregion

        #region Properties
        // Abstraction --> features of class / access of internal affairs /interal member 
        // Get -> reading the data / information 
        // Set --> writing informatiomn / setting the information  
        
        public int Id 
        { 
            get
            {
                // reading the data
                return _id;
            }
            //set 
            //{
            //    // writing a new information / new value
            //    // setting our new information / new new 
            //    _id = value;
            //}
        }
        public string  Model
        {
            get
            {
                // reading the data
                return _model;
            }
            //set
            //{
            //    // writing a new information / new value
            //    // setting our new information / new new 
            //    _model = value;
            //}
        }
        public string Year
        {
            get
            {
                // reading the data
                return _year;
            }
            //set
            //{
            //    // writing a new information / new value
            //    // setting our new information / new new 
            //    _year = value;
            //}
        }

        public string Color
        {
            get
            {
                // reading the data
                return _color;
            }
            //set
            //{
            //    // writing a new information / new value
            //    // setting our new information / new new 
            //    _color = value;
            //}
        }

        #endregion

        #region Constructor

        // Initialization the values 
        // Setting the values
        // Passign new setting values via Parameter
        // Specialized method
        // you can constructor for Method Overloading purpose
        // constructor always called once time when you define a object
        public Car(int id , string model , string year , string color)
        {
            _id = id;
            _model = model;
            _year = year;
            _color = color;
        }
        public Car()
        {
                
        }

        // Method overloading - same name of method but differnt parameter 
        public Car(int id)
        {
            _id = id;
        }
       
        public Car(int id , string year)
        {
            _id = id;
            _year = year;
        }

        #endregion

        #region Normal Method

        // key as parameter
        // key as a input
        // retuen type of this method is String
        public string Start(int key)
        {
            return $"Start the Car by-{key}";
        }

        public string  Move(string start)
        {
            return $" Move the Car - {start}";
        }

        public string Stop(string move)
        {
            return $"Stop the Car - {move}";
        }
        #endregion

        #region ToStringMethod
        // retrieve all the information ToString()
        // Microsoft by default provide you in using System namespace 
        public override string ToString()
        {
            // i want to modify this method with my own implemntation
            return $"Id -{Id} , Model-{Model} , Year- {Year}, Color- {Color}";
        }

        #endregion


    }
}
