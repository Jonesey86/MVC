using System.Runtime.Intrinsics.Arm;

public class Model 
{
    public string? Name { get; set;}
    public int? Age { get; set; }

    // constructor
    public Model(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    // Override string method
    public override string ToString()
    {
        return  $"Name: {Name}. Age {Age}";
    }
}