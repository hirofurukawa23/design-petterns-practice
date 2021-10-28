using AbstractFactory_pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_pattern.ListFactory
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><head>{ title }</title></head>\n");
            sb.Append($"<body>\n");
            sb.Append($"<h1>{ title }</h1>\n");
            sb.Append($"<ul>\n");
            var it = content.GetEnumerator();
            while(it.MoveNext())
            {
                Item item = (Item)it.Current;
                sb.Append(item.MakeHtml());
            }
            sb.Append($"</ul>\n");
            sb.Append($"<hr><address>{ author }</address>");
            sb.Append($"</body></html>\n");
            return sb.ToString();
        }
    }
}
