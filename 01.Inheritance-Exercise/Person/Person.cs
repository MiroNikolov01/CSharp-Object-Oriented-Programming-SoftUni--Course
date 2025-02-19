using System;
using System.Text;

namespace Person;

public class Person
{
    private string _name;
    private int _age;

    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(String.Format($"{this.GetType().Name} -> "));
        sb.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));
        return sb.ToString();
    }
}