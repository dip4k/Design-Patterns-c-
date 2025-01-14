﻿namespace DotNetDesignPattern.Creational.Builder
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}