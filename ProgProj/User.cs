using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class User
{
    public string Name { get; private set; }

    public void GetName()
    {
        Console.Write("Buck: What is your name? ");
        Name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = "Guest";
        }
    }
}
