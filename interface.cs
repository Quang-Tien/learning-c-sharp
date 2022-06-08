using System;
interface Animal
{
    void animalSound(); 
}


class Pig : Animal
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();
    }
}