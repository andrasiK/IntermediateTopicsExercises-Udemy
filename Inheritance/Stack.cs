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
        private List<object> stackList { get; set; }

        public Stack()
        {
            stackList = new List<object> { };
        }

        // Methods
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null value passed as a parameter");
            }
            else
            {
                stackList.Add(obj);
            }
            
        }
        public object Pop()
        {
            var upperElement = stackList.Last();

            var index = (stackList.Count()) - 1;
            stackList.RemoveAt(index);
            return upperElement;
        }

        public void Clear()
        {
            stackList.Clear();
        }
    }
}
