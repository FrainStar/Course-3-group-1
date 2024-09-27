namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        DataClass.CreateFile("./1.csv");
        Record rec = new Record("1", "1", "1", 1, 1.0);
        DataClass.CreateRecord(rec, "./1.csv");
        DataClass.CreateRecord(rec, "./1.csv");
        DataClass.ReadFile("./1.csv");
    }
}
