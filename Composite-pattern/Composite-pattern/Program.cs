using System;

namespace Composite_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making root entry...");
            Directory rootdir = new Directory("root");
            Directory bindir = new Directory("bin");
            Directory tmpdir = new Directory("tmp");
            Directory usrdir = new Directory("usr");
            rootdir.Add(bindir);
            rootdir.Add(tmpdir);
            rootdir.Add(usrdir);
            bindir.Add(new File("vi", 10000));
            bindir.Add(new File("latex", 20000));
            rootdir.PrintList();

            Console.WriteLine();
            Console.WriteLine("Making user entry...");
            Directory yuki = new Directory("Yuki");
            Directory hanako = new Directory("Hanako");
            Directory tommy = new Directory("Tommy");
            usrdir.Add(yuki);
            usrdir.Add(hanako);
            usrdir.Add(tommy);
            yuki.Add(new File("dir.html", 100));
            yuki.Add(new File("composite.java", 200));
            hanako.Add(new File("memo.txt", 300));
            tommy.Add(new File("game.doc", 400));
            tommy.Add(new File("junk.mail", 500));
            rootdir.PrintList();

            Console.ReadLine();
        }
    }
}
