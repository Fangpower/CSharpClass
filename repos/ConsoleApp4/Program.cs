using System.Linq.Expressions;

namespace ConsoleApp4 {
    internal class Program {
        static void Main(string[] args) {
            // Get the file name 

            Console.Write("Grade input text file name (without extension): ");

            string fileName = Console.ReadLine();

            // Attempt to process the grade data 
            string filePath = @"..\..\..\";
            if (File.Exists(filePath + fileName + ".txt")) {
                StreamReader inFile = new StreamReader(
                  new FileStream(filePath + fileName + ".txt", FileMode.Open));
                StreamWriter outFile = new StreamWriter(
                  new FileStream(filePath + fileName + "WithLetters.txt",
                                 FileMode.Create));

                // Read grades, convert to letter grades, and write to file. 
                string record;
                while ((record = inFile.ReadLine()) != null) {
                    int grade = 0;
                    try {
                        grade = int.Parse(record);
                    } catch {
                        Console.WriteLine("Unknown Number!");
                    }
                    outFile.WriteLine($"{grade,3}: {ConvertGrade(grade),3}");
                }
                inFile.Close();
                outFile.Close();
                Console.WriteLine("Grade processing complete.");
            } else {
                Console.WriteLine(filePath + fileName + ".txt does not exist.");
            }
        } // end Main 



        static string ConvertGrade(int grade) {
            string letterGrade = "F";
            if (grade >= 100)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            return letterGrade;
        }
    }
}