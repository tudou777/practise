using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    public class Dog : IEnumerable
    {
        IList<string> dogs;
        //private int count;
        public Dog()
        {
            dogs = new List<string>();
        }
        public int Count
        {
            get { return dogs.Count; }

        }
        public string this[int index]
        {
            set
            {
                dogs.Add("My name is " + value);
                //dogs[index] = "My name is " + value;
            }
            get
            {
                if (index < dogs.Count)
                {
                    return dogs[index];
                }
                else
                {
                    return "N/A";
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new OperatorClass(this);
        }
    }
    public class OperatorClass : IEnumerator
    {
        Dog operD;
        int counter = 0;
        public OperatorClass(Dog d)
        {
            operD = d;
        }

        public object Current
        {
            get { return operD[counter++]; }
        }

        public bool MoveNext()
        {
            if (counter < operD.Count)
            {
                //counter++;
                return true;
            }
            else
            {
                return false;
            }


        }

        public void Reset()
        {
            counter = 0;
        }
    }
}
