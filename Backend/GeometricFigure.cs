namespace Backend;

public abstract class GeometricFigure
{
    //Constructors
    protected GeometricFigure(String name)
    {
        Name = name;
    }


    //Properties
    public String Name 
    { get; set; } = null!;


    //Methods
    public override string ToString()
    {
        //return $"Figura: {Name}\n" +
        // $" => Area......: {GetArea():N5}\n" +
        //$" => Perimeter.: {GetPerimeter():N5}\n" +
        //$"---------------------------";

        return $"{Name,-15} => Area.....: {GetArea(),15:N5}   Perimeter: {GetPerimeter(),15:N5}";
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
}
