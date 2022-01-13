/*
    The Following Type of Variables are avaliable in C#:
        1) Interger -> 4 byte
        2)Charachter -> 2 byte
        3)Float -> 4byte
        4)Double -> 8byte
        5)Boolean -> 1bit
        6)String -> @bytes per charachter
*/

//Data Types

int a = 32;
float b = 32.677657657656574754F;
char c = 'a';
double d = 32.675875858755757575; //D is optional
bool e = false;
string f = "Hi I am Yogesh Gaur !!!";

Console.WriteLine("Value of a is " + a);
Console.WriteLine("Value of b is " + b);
Console.WriteLine("Value of c is " + c);
Console.WriteLine("Value of d is " + d);
Console.WriteLine("Value of e is " + e);
Console.WriteLine("Value of f is " + f);

//Type Conversion

string s = Console.ReadLine();
string s1 = Console.ReadLine();
int num1 = Convert.ToInt32(s); //Explicit Casting
double num2 = Convert.ToDouble(s1); //Explicit Casting

Console.WriteLine(num1+num2);
int num3 =  (int) num2; //Typecasting into int
Console.WriteLine(num1+num3); //Int +Int = Int

