// See https://aka.ms/new-console-template for more information

//using System means that we can use classes from the System namespace.
using System;
namespace MyApp
//namespace is used to organize your code, and it is a container for classes and other namespaces.
{ 
//class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
 internal class Program{
        static void Main(String[] args){
            //output 
            Console.WriteLine("I love you Nikita");
            Console.WriteLine(49+51);
            Console.Write("This will print in the same line intstead of new line");
            Console.Write(" -- see its the same line -- ");

            /* multiple 
            line 
            comment */

            //Variables

            string name = "Anand";
            Console.WriteLine(name);

            int myNum = 15;
            myNum = 40;
            Console.WriteLine(myNum);

            int newNum;
            newNum = 300 + 200;
            Console.WriteLine(newNum);

            //Other Datatypes 

            int yNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            //Constants
            const int aNum =15;
            //aNum = 45; //error

            Console.WriteLine("Hello " + name + ". How are you?");

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            /* C# Identifiers
                Names can contain letters, digits and the underscore character (_)
                Names must begin with a letter or underscore
                Names should start with a lowercase letter, and cannot contain whitespace
                Names are case-sensitive ("myVar" and "myvar" are different variables)
                Reserved words (like C# keywords, such as int or double) cannot be used as names
            */

            // Get user Input 

            Console.WriteLine("What is your name?");
            string userName =  Console.ReadLine();
            Console.WriteLine("hello " + userName);


            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"    

            //STRING INTERPOLATION 

            string fName = "John";
            string lName = "Doe";
            string fullname = $"My full name is: {fName} {lName}";
            Console.WriteLine(fullname);


            string txt1 = "We are the so-called \"Vikings\" from the north.";
           
            if(20 > 18){
                Console.WriteLine("20 is greater than 18");
            }

            int time = 22;
            if (time < 10)
            {
            // block of code to be executed if condition1 is True
                Console.WriteLine("Good Morining");
            } 
            else if (time < 20) 
            {
            // block of code to be executed if the condition1 is false and condition2 is True
                 Console.WriteLine("Good Day");
            } 
            else
            {
            // block of code to be executed if the condition1 is false and condition2 is False
                Console.Write("Good Evening");
            }

            for(int i = 0; i < 5; i++){
                Console.WriteLine(i);
            }

                // Outer loop
            for (int i = 1; i <= 2; ++i) 
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times
                
                // Inner loop
                for (int j = 1; j <= 3; j++) 
                {
                Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
                }
            } 


        }
    }
}

//System.Console.WriteLine("If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.");
