using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab10.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

    public void SayHello(){
        Console.WriteLine("Hello");
    }
    }

}