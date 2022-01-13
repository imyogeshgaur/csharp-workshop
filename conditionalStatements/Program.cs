/* Conditional Statements are of Following Types : 
    1) If else
    2) switch
    3) Nesetd If Else
*/

//If else Statement 

string s1 = Console.ReadLine();
Console.WriteLine("The First Number inputed by User is : " + s1);
string s2 = Console.ReadLine();
Console.WriteLine("The Second Number inputed by User is : " + s2);

int num1 = Convert.ToInt32(s1);
int num2 = Convert.ToInt32(s2);

if (num1 > num2)
{
    Console.WriteLine("First Number is Greater !!!");
}else
{
     Console.WriteLine("Second Number is Greater !!!");
}

//Switch Statement 

string s3 = Console.ReadLine();
Console.WriteLine("The Number inputed by User is : " + s3);

int val = Convert.ToInt32(s3);

switch (val)
{
    case 1: Console.WriteLine("Monday");
            break;
    case 2: Console.WriteLine("Tuesday");
            break;
    case 3: Console.WriteLine("Wednesday");
            break;
    case 4: Console.WriteLine("Thrusday");
            break;
    case 5: Console.WriteLine("Friday");
            break;
    case 6: Console.WriteLine("Saturday");
            break;
    case 7: Console.WriteLine("Sunday");
            break;
    default:Console.WriteLine("Please Choose Correct Day !!!");
            break;
}

// Ladder If Else

string s4 = Console.ReadLine();
Console.WriteLine("The First Number inputed by User is : " + s4);
string s5 = Console.ReadLine();
Console.WriteLine("The Second Number inputed by User is : " + s5);

int num3 = Convert.ToInt32(s4);
int num4 = Convert.ToInt32(s5);

if (num3 > num4)
{
    Console.WriteLine("First Number is Greater !!!");
    if(num3 %2 == 0){
        Console.WriteLine("Even Number !!!");
    }else{
       Console.WriteLine("Odd Number !!!");
    }
}else
{
     Console.WriteLine("Second Number is Greater !!!");
      if(num3 %2 == 0){
        Console.WriteLine("Even Number !!!");
    }else{
       Console.WriteLine("Odd Number !!!"); 
    }
}
