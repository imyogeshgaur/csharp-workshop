
//Simple Calculator

//Addition Function

void additionOfNumbers(double first,double second){
    Console.WriteLine(first+second);
}

//Sunstraction Function

void substractionOfNumbers(double first,double second){
    if(first > second){
        Console.WriteLine(first-second);
    }else{
        Console.WriteLine(second-first);
    }
}

//Multiplication Function

void multiplicationOfNumbers(double first,double second){
    Console.WriteLine(first*second);
}

//Division Function

void divisionOfNumbers(double first,double second){
     if(first > second){
        Console.WriteLine(Convert.ToDouble(first/second));
    }else if(second > first){
        Console.WriteLine(Convert.ToDouble(second/first));
    }else{
        Console.WriteLine("Division is not Performed !!!");
    }
}


string s1 = Console.ReadLine();
string s2 = Console.ReadLine();

double num1 = Convert.ToDouble(s1);
double num2 = Convert.ToDouble(s2);

additionOfNumbers(num1,num2);
substractionOfNumbers(num1,num2);
multiplicationOfNumbers(num1,num2);
divisionOfNumbers(num1,num2);
