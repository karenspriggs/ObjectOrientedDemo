using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebAppMVC.Models
{
    public class Cat : ICat
    {
        string name;
        int age;
        string description;

        public Cat()
        {
            name = "Generic Cat";
            age = 1;
            description = "This is a generic cat";
        }

        public Cat(string name, int age, string description)
        {
            this.name = name;
            this.age = age;
            this.description = description;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
    }
}