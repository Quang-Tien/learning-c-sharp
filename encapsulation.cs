using System;
class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person teacher = new Person();
        teacher.Name = "John";
        Console.WriteLine(teacher.Name);
    }
}