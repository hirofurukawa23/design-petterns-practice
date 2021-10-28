using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AbstractFactory_pattern.Factory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected IList<Item> content = new List<Item>();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            content.Add(item);
        }

        public void Output()
        {
            try
            {
                var fileName = $"{ title }.html";
                File.WriteAllText(Path.Combine(@"D:\temp", fileName), 
                                  this.MakeHtml(),
                                  Encoding.GetEncoding("shift_jis"));
                Console.WriteLine($"{ fileName }を作成しました。");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public abstract string MakeHtml();
    }
}
