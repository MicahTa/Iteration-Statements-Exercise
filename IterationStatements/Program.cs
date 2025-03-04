using System.Collections.Specialized;

namespace IterationStatements
{

    public class Program
    {
        static void PrintNumbers() {
            for (int i = 1000; i >= -1000; i-=1) {
                Console.Write($"{i}\t");
            }
        }

        static void PrintEveryThirdNumber() {
            for (int i = 3; i <= 999; i+=3) {
                Console.Write($"{i}\t");
            }
        }

        static bool AreNumbersEqual(int num1, int num2) {
            return (num1 == num2);
        }
        
        static bool IsEven(int number) {
            return ((number % 2) == 0 ? true: false);
        }
        
        static bool IsPositive(int number) {
            return (number > 0 ? true: false);
        }
        
        static bool CanVote(int age) {
            return (age > 18 ? true: false);
        }
        
        static bool IsInRange(int number) {
            return ((number >= -10) && (number <= 10) ? true: false);
        }
        
        static void DisplayMultiplicationTable(int? number = null, int size = 12) {
            /*
                Either create a entire multiplication table or a multiplication table for specific value
                number -> creates multiplication table for specific value (Such as 3, 6, 9, 12.....)
                size -> determes size of multiplication table
            */
            if (number == null) {

                //////// For entire multiplication table ////////
                // Create numbers on top
                Console.Write($"\n\t");
                for (int i = 1; i<=size; i++) {
                    Console.Write($"{i}\t");
                }

                // Create each row
                for (int i = 1; i<=size; i++) {
                    Console.Write("\n");
                    // Create numbers on side
                    Console.Write($"{i}\t");
                    // Create table per coulmn
                    for (int s = 1; s<=size; s++) {
                        Console.Write($"{i*s}\t");
                    }
                }


                //////// create multiplication table for specific value ////////
            } else {
                for (int i = 1; i<=size; i++) {
                    Console.WriteLine($"{i}\t{i*number}");
                }
            }
        }


        static void Main(string[] args) {
            
            Console.WriteLine("Writing every number from 1000 to -1000");
            PrintNumbers();

            Console.WriteLine("\n\nWriting every third number from 3 to 999");
            PrintEveryThirdNumber();

            Console.WriteLine("\n\nDoes 1=1?");
            Console.WriteLine(AreNumbersEqual(1,1));
            Console.WriteLine("Does 1=0?");
            Console.WriteLine(AreNumbersEqual(1,0));

            Console.WriteLine("\nIs 1 even?");
            Console.WriteLine(IsEven(1));
            Console.WriteLine("Is 2 even?");
            Console.WriteLine(IsEven(2));

            Console.WriteLine("\nIs 2 positive?");
            Console.WriteLine(IsPositive(2));
            Console.WriteLine("Is -2 positive?");
            Console.WriteLine(IsPositive(-2));

            Console.WriteLine("\nCan a two year old vote?");
            Console.WriteLine(CanVote(2));
            Console.WriteLine("Can a 19 year old vote?");
            Console.WriteLine(IsPositive(19));

            Console.WriteLine("\nIs -11 in-between -10 and 10?");
            Console.WriteLine(IsInRange(-11));
            Console.WriteLine("Is 0 in-between -10 and 10?");
            Console.WriteLine(IsInRange(0));
            Console.WriteLine("Is 11 in-between -10 and 10?");
            Console.WriteLine(IsInRange(11));

            Console.WriteLine("\nGenerating multiplication table of 3's");
            DisplayMultiplicationTable(3);
            Console.WriteLine("\n\nGenerating multiplication table");
            DisplayMultiplicationTable();
        }
    }
}
