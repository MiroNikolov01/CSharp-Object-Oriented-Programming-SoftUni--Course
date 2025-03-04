using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < MinAge || value > MaxAge)
                    throw new ArgumentException($"Age should be between {MinAge} and {MaxAge}.");
                this.age = value;
            }
        }

        public double ProductPerDay => CalculateProductPerDay();

        private double CalculateProductPerDay()
        {
            return this.Age switch
            {
                <= 3 => 1.5,
                <= 7 => 2,
                <= 11 => 1,
                _ => 0.75
            };
        }
    }
}