class Student
{
    private int RollNumber;
    private string NameOfStudent;
    private float MarksOfStudent;

    Student(int roll,string name,float marks){
         this.RollNumber = roll;
        this.NameOfStudent = name;
        this.MarksOfStudent = marks;
    }

    public void getData(int roll,string name,float marks){
        this.RollNumber = roll;
        this.NameOfStudent = name;
        this.MarksOfStudent = marks;
    }
    public void showData(){
        Console.WriteLine("Name of the Student is : "+NameOfStudent);
        Console.WriteLine("Roll Number of the Student is : "+RollNumber);
        Console.WriteLine("Marks of the Student is : "+MarksOfStudent);
    }

    static void Main(){
        Student s = new Student(0,"XYZ",0.0F); 
        s.getData(1,"Yogesh",45.56F);
        s.showData();//Default values are passed by constructor i.e 0,xyz and 0.0F
    }
}

