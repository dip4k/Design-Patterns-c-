﻿namespace DotNetDesignPattern.Creational.Builder
{
    public class PersonInfoBuilder<SELF> : PersonBuilder
      where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }
}