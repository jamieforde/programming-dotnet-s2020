using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Data structure that contains elements can be understood independently of the types it manipulates
 * A generic class provides a means to describing a class in a type-independent way.
 * We can then instantiate type specific versions of the generic class
 * Software resuability
 * Indicate the actual types that should be used with the class in place of the type parameters list
 * Compile time -> ensures type safety
 * Runtime -> compiler replaces type parameter with type arguments
 * So lets create a Stack that can work with double, ints, char, employee
 * We have  
 * 
*/

namespace Week11_GenericClasses
{
    public class Stack<T>
    {
        private int top;
        private T[] elements;

        public Stack() : this(10)
        {

        }

        public Stack(int stackSize)
        {
            if (stackSize <= 0)
            {
                throw new ArgumentException("Stack size must be greater than 0");
            }

            elements = new T[stackSize];
            top = -1;
        }

        public void Push(T pushValue)
        {
            if(top == elements.Length - 1)
            {
                throw new FullStackException($"Stack is full, cannot push {pushValue}");
            }

            ++top;
            elements[top] = pushValue;
        }

        public T Pop()
        {
            if(top == -1)
            {
                throw new EmptyStackException($"Stack is empty, cannot pop");
            }

            --top;
            return elements[top + 1];
        }

    }
}
