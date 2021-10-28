using AbstractFactory_pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            const string libraryName 
                = "AbstractFactory_pattern.ListFactory.ListFactory";

            Console.WriteLine($"Type \"{ libraryName }\"");
            var input = Console.ReadLine();
            if (input != libraryName)
            {
                Console.WriteLine($"Usage: Type \"{ libraryName }\"");
                Console.ReadLine();
            }
            else
            {
                Factory.Factory factory = Factory.Factory.GetFactory(input);

                Link asahi = factory.CrateLink("朝日新聞", "https://www.asahi.com/");
                Link yomiuri = factory.CrateLink("読売新聞", "https://www.yomiuri.co.jp/");

                Link usYahoo = factory.CrateLink("Yahoo!", "https://www.yahoo.com/");
                Link jpYahoo = factory.CrateLink("Yahoo!Japan", "https://www.yahoo.co.jp/");
                Link excite = factory.CrateLink("Excite", "https://www.excite.co.jp/");
                Link google = factory.CrateLink("Google", "https://www.google.com/");

                Tray trayNews = factory.CreateTray("新聞");
                trayNews.Add(asahi);
                trayNews.Add(yomiuri);

                Tray trayYahoo = factory.CreateTray("Yahoo!");
                trayYahoo.Add(usYahoo);
                trayYahoo.Add(jpYahoo);

                Tray traySearch = factory.CreateTray("サーチエンジン");
                traySearch.Add(trayYahoo);
                traySearch.Add(excite);
                traySearch.Add(google);

                Page page = factory.CreatePage("LinkPage", "HIRO");
                page.Add(trayNews);
                page.Add(traySearch);
                page.Output();

                Console.ReadLine();
            }
        }
    }
}
