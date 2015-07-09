using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Singleton
{
    public static class Singleton
    {
       static Person p;
       //private Singleton()
       //{

       //}
        public static Person GetInstance(string name)
        {
            if (p == null)
            {
                p = new Person();
                p.Name = name;
            }
            return p;
        }
    }
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}