using System;

namespace Planner
{
    class Building
    {
    public string _designer {get; set;}
    private DateTime _dateConstructed {get; set;}
    private string _address {get; set;}
    public string _owner {get; set;}

    public int Stories {get; set;}
    public double Width {get; set;}
    public double Depth {get; set;}
    public  double Volume
    {
        get {
            return Width * Depth * (3 * Stories);
            }
    }
     public Building(string address)
     {
         {
             _address = address;
        }
     }

    public void Construct() {
    _dateConstructed = DateTime.Now;
    }

    public void Purchase(string NameOfBuyer) {
        _owner = NameOfBuyer;
    }

    public void Designer (string NameofDesigner) {
            _designer = NameofDesigner;
    }

    public void CubicMeters () {

    }

    public void Description() {
        Console.WriteLine($"----------------------------");
        Console.WriteLine($"{_address}");
        Console.WriteLine($"{_dateConstructed}");
        Console.WriteLine($"Bought by {_owner}");
        Console.WriteLine($"Designed by {_designer}");
        Console.WriteLine($"Cubic Meters {Volume}");


    }


    }
}