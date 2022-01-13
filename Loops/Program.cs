/*
   There are three Types of Loop is C#:
    1)For Loop
    2)While Loop
    3)Do While Loop

*/

//For Loop

string s = Console.ReadLine();
int number = Convert.ToInt32(s);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(number + " * " + i + " = " + number*i);
}

//While Loops

int p = 1;
string s1 = Console.ReadLine();
int number2 = Convert.ToInt32(s1);
while (p <= 10)
{
   Console.WriteLine(number2 + " * " + p + " = " + number2*p);  
   p++;
}

//Do While Loops

int q=1;
string s2 = Console.ReadLine();
int number3 = Convert.ToInt32(s2);
do
{
    Console.WriteLine(number3 + " * " + q + " = " + number3*q);  
    q++;
} while (q <= 10);