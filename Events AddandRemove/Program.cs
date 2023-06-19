using System;

//ref link:https://www.youtube.com/watch?v=qAQRzWtfqNQ&list=PLAE7FECFFFCBE1A54&index=18
//

class Cow
{
    //public event Action Mooing;
    private Action mooing;
    public event Action Mooing{
        add 
        { 
            mooing += value;
            mooing += value;
            mooing += value;
            Console.WriteLine("addding"); 
        }
        remove { mooing -= value; Console.WriteLine("removing"); }
    }
    public void PushSleepingCow()
    {
        // .....
        if(mooing != null) 
            mooing();
    }
}

class MainClass
{
    static void Main()
    {
        Cow c = new Cow();
        c.Mooing += () => Console.WriteLine("Giggle");
        c.PushSleepingCow();
    }
}