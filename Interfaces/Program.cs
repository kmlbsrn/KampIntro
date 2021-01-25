using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface Iperson
    {
        int Id { get; set; }
        public int MyProperty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Iperson
    {
        public int Id { get set ; }
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Student:Iperson
    {

    }
}
