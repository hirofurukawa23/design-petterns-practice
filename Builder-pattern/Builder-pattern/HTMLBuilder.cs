using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Builder_pattern
{
    public class HTMLBuilder : Builder
    {
        private string _filename;
        private string _path;
        List<string> _lines = new List<string>();

        public override void MakeTitle(string title)
        {
            _filename = $"{title}.html";
            try
            {
                _path = Path.Combine(@"D:\temp", _filename);
                _lines.Add($"<html><head><title>{ title }</title></head><body>");
                _lines.Add($"<h1>{ title }</h1>");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void MakeString(string str)
        {
            _lines.Add($"<p>{ str }</p>");
        }

        public override void MakeItems(List<string> items)
        {
            _lines.Add($"<ul>");
            foreach(var item in items)
            {
                _lines.Add($"<li>{ item }</li>");
            }
            _lines.Add($"</ul>");
        }

        public override void Close()
        {
            _lines.Add("</body></html>");
            File.WriteAllLines(_path, _lines, Encoding.GetEncoding("shift_jis"));
        }

        public string GetResult()
        {
            return _filename;
        }
    }
}
