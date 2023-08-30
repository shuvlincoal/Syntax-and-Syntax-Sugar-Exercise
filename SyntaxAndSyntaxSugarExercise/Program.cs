namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void  Main(string[] args)
        {
            
            var answer = 4; //inferred typing

            var response =  answer <9 ?  " answer is less than nine" : "answer is greater than or equal to nine";

            Console.WriteLine($" {response} ");
            //if (answer < 9)
            //{
            //response = answer;
            //    Console.WriteLine($" {answer} is less than nine");

            //}
            //else
            //{
            //    Console.WriteLine($" {answer} is greater than or equal to nine");
            //}


        }
    }
}
