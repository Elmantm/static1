namespace ConsoleApp14
{
    internal class Student
    {
        public static int Count { get; set; }
        public int Id { get; set; }
        public Student()
        {
            Count++;
            Id = Count;
        }
    }

}
