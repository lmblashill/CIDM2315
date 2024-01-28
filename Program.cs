namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input your grade letter");
        string gpa = Console.ReadLine();
        
        
        if(gpa == "A")
        {
            Console.WriteLine("GPA is 4");
        }
        else if (gpa == "B")
        {
            Console.WriteLine("GPA is 3");
        }
        else if (gpa == "C")
        {
            Console.WriteLine("GPA is 2");
        }    
        else if (gpa == "D")
        {
            Console.WriteLine("GPA is 1");
        }
        else if (gpa == "F") 
        {
            Console.WriteLine("GPA is 0");
        }
        else
        { 
            Console.WriteLine("GPA is invalid:");
        }

    }



        }
    

