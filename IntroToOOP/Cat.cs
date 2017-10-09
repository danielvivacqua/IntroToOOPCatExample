using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //STATES
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //BEHAVIORS

        //Constructors
        public Cat()
        {
            //default constructor because it takes no 
            //parameters in the parentheses
        }

    }
}
