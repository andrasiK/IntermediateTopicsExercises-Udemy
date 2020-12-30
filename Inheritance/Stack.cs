using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Stack
    {
       

        // Properties
        private List<object> StackList { get; set; }

        public Stack()
        {
            StackList = new List<object> { };
           
        }

        // Methods
        public void Push(object obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    StackList.Add(obj);
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Can't pass NULL value!");
            }
            
            
        }
        public object Pop()
        {
            var upperElement = StackList.Last();

            var index = (StackList.Count()) - 1;
            StackList.RemoveAt(index);
            return upperElement;
        }

        public void Clear()
        {
            StackList.Clear();
        }
    }
}
