namespace LINQAssignment
{
    internal class Question1
    {
        static void Main(string[] args)
        {
            //Given an array of numbers. Find  the cube of the numbers that are greater than 100 but less than 1000 using LINQ.

            try
            {
                int[] numbers = { 100,2,4,2000,200,400};
                var result = from num in numbers
                             where num>100 && num<1000
                             select num;

                foreach (var num in result)
                {
                    Console.WriteLine(num*num*num);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
