using System;

namespace GradeBook{

    public delegate string WriteLogDelegate(string log);

    class Compute{
        static public double addGrade(double[]? grades){
            double result = 0.0;
            foreach(double grade in grades){
                result += grade;
            }
            return result;
        }

        static public double addGrade(List<double> grades){
            double result = 0.0;
            foreach(double grade in grades){
                result += grade;
            }
            return result;
        }

        static public double averageGrades(List<double> grades){
            double total = addGrade(grades);
            return total/grades.Count();
        }
    }


    class Program{
        static void Main(string[] args){
            Console.WriteLine("Please Enter Grade (type q to quit)");
            var input= "start";
            List<double> grades = new List<double> ();
            while(true){
                input = Console.ReadLine();
                if(input == "q"){
                    break;
                }
                try{
                    var grade = double.Parse(input);
                    grades.Add(grade);
                } catch(FormatException e){
                    Console.WriteLine($"Ivalid Grade: {input}");
                }
            }
            Book book = new Book(grades);
            book.SetName("Test");
            book.WriteToFile();
            Console.WriteLine(book.ReadFromFile());
        }
    }

}
