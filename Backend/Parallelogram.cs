namespace Backend;

public class Parallelogram:Rectangle
{
    //Fields

    private double _h;





    //Constructors
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        
        H = h;
    }



    //Properties

    public double H 
    { 
        get => _h; 
        set => _h = ValidateH(value); 
    }



    //Methods
    public override double GetArea() => B * H;
  
    public override double GetPerimeter() => base.GetPerimeter();




    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(h), $"The height: {h} is invalid.");
        }
        return h;
    }
}
