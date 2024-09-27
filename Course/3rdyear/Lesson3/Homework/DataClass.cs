namespace Homework;
using System.IO;
using System.Collections.Generic;

public static class DataClass 
{
    public static void CreateFile(string path) 
    {
        using (FileStream fs = File.Create(path)) {};
        Console.WriteLine($"File create");
        return;
    }

    public static void CreateRecord(Record rec, string path) 
    {
        List<string> def = new List<string>();
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                def.Add(s);
            }
        }

        string res = rec.Date.ToString() + ";" + rec.Product.ToString() + ";" + rec.Region.ToString() + ";" + rec.Quantity.ToString() + ";" + rec.Price.ToString() + ";";
        def.Add(res);
        File.WriteAllLines(path, def);
        Console.WriteLine("Record create");
        return;
    }

    public static void ReadFile(string path)
    {
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}