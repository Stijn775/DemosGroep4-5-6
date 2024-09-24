using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExample
{
    internal class InvalidAgeException : Exception
    {
        #region Public Constructors

        public InvalidAgeException() : base("Age is below zero")
        {
        }

        #endregion Public Constructors
    }

    internal class Person
    {
        #region Fields

        private int age;

        #endregion Fields

        #region Properties

        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new InvalidAgeException();
                }
                age = value;
            }
        }

        #endregion Properties
    }
}