using System.Collections;

namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap Chuoi: ");
        string s = Console.ReadLine();
        Stack<char> myStack = new Stack<char>();
        foreach(char curChar in s)
        
            if (curChar == '(' || curChar == '[' || curChar== '{')
            {
                myStack.Push(curChar);
            }
            else
            {
                if (myStack.Count == 0)
                {
                    Console.WriteLine("false");
                }
                char prevChar = myStack.Pop();
                if (prevChar == '(' && curChar != ')'
                    || prevChar == '[' && curChar != ']'
                    || prevChar == '{' && curChar != '}')
                {
                    Console.WriteLine("false");
                }
            }

            if (myStack.Count > 0)
            {
                Console.WriteLine("false");
            }
            
        }
        


    }
