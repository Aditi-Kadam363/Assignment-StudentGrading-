namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 85, 90, 78, 88, 92 };
            Student student = new Student("Aditi", 101, marks);
            Console.WriteLine(student.ToString());

        }
    }
}
