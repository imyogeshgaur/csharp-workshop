//Arrays are declared in following Ways in c#

//Declaration 1
// RollNumber = new Int32{1,2,3};

//Declaration 2
// int [] empNumb = {1001,1002,1003};

/* Array are called by following ways :
    1) Loops
        a)For Loop 
        b)While Loop
        c)Do While Loop
    2) For Each
*/
class myArray
    {
        static void Main(String[] args){
            string[]  s = new string[]{"Yogesh","Mukesh","Ramesh"};  
            //For Each 
            foreach (string item in s)
            {
                Console.WriteLine(item);
            }
            //For Loop
            int[] RollNumber = {1,2,3};
            for (int i = 0; i <RollNumber.Length; i++)
            {
                Console.WriteLine(RollNumber[i]);
            }

            //While Loop
            int p = 0;
            int[] RollNumber1 = {4,5,6};
            while (p != RollNumber1.Length)
            {
                Console.WriteLine(RollNumber1[p]);
                p++;
            }

            //Do While Loop
            int[] RollNumber2 = {7,8,9};
            int q = 0;
            do
            {
                Console.WriteLine(RollNumber2[q]);
                q++;
            } while (q != RollNumber2.Length);
        }
}


