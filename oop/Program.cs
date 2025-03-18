using oop.Model;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher alice = new Teacher();
            Teacher bob = new();
            var costas = new Teacher();

            Teacher anna = new Teacher() // object initializer
            {
                Id = 1,
                Firstname = "Anna",
                Lastname = "Smith"
            };

            Teacher andreas = new Teacher(2, "Andreas", "Papadopoulos");
        }
    }
}
