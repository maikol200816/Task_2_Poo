namespace Backend;

public abstract class GeometricFigure
{
    //Constructors
    protected GeometricFigure(string name)
    {
        Name = name;
    }


    //Properties
    public string Name 
    { get; set; } = null!;


    //Methods
    public override string ToString()
    {
        

        return $"{Name,-15} => Area.....: {GetArea(),15:N5}   Perimeter: {GetPerimeter(),15:N5}";
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
}
