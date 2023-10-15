using System.Reflection;

public class Treasure : Thing {
    private double _value;
    public Treasure(string aName, string aDescription, double aValue): base(aName, aDescription){
        _value = aValue;
    }
    public double Value{
        get {
            return _value;
        }
        set { _value = value; 
        }
    }
}

public class Thing{
    private string _name;
    private string _description;

    public Thing(string aName, string aDescription){
        _name = aName;
        _description = aDescription;
    }

    // the get and set, allows to retrieve the property without using a method, works like a variable
    public string Name{
        get {
            return _name;
        }
        set {
            _name = value;
        }

    }

    public string Description{
        get {
            return _description;
        }
        set {
            _description = value;
        }        
    }
}
