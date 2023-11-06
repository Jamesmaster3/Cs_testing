// See https://aka.ms/new-console-template for more information
using System.Reflection;
// other classes exist within the same namespace, namely: the system.reflection namespace. And in the same directory. This allows me to call them.

Console.WriteLine("Hello, World!");

// Simple Class
MyClass ob;
ob = new MyClass();
ob.SetS("Goodbye world!");
Console.WriteLine(ob.GetS());



// Class with retrievable and editable properties
// Class is called from other file -> best practice
Thing thingOb;
// retrieving name using property
thingOb = new Thing("Jim", "A good programmer");
Console.WriteLine(thingOb.Name);

//editing and retrieving name using property
thingOb.Name = "James";
Console.WriteLine(thingOb.Name);



// class based (": base(aName, aValue)") on the thing class
Treasure tr1;
tr1 = new Treasure("Pot of gold", "A large pot filled with gold coins", 100);

// writing all my objects in a line
Console.WriteLine($"You found a {tr1.Name} worth {tr1.Value} coins!");



class MyClass {
    private string _s;
    public MyClass(){
        _s = "Hello world";
    }
    public string GetS(){
        return _s;
    }
    public void SetS(string aString){
        _s = aString;
    }
}


