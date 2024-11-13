using System;
using ConsoleApp7;//using the original name for this project 
namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Demos\info.txt";

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Person newperson = new Person();

                newperson.Address = entries[0];
                newperson.FirstName = entries[1];
                newperson.Age = entries[2];
                // entries.length
                people.Add(newperson);
            }
            Console.WriteLine("Read from text file");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.Age}: {person.Address}");
            }

            people.Add(new Person { FirstName = "Name: Connor", Address = "Address: 6419 Transpotation Street", Age = "Age: 22" });
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add(person.FirstName);
                output.Add(person.Address);
                output.Add(person.Age);
            }
            Console.WriteLine("writing to text file");
            File.AppendAllLines(filepath, output);
            Console.WriteLine("all entries written");
            Console.ReadLine();
        }
    }
  
}
