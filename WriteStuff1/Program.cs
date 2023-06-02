using System;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path=GetFullPath(args);
            Queue<string>strings=new Queue<string>();

            string a=Console.ReadLine();
            strings.add(a);
            while (a!=null)
            {
                string a=Console.ReadLine();
                strings.add(a);
            }

            using (StreamWriter outputfile= new StreamWriter(path))
            {
                foreach(string a in strings)
                {
                    outputfile.WriteLine(a);
                }
            }


        }
    }
}
