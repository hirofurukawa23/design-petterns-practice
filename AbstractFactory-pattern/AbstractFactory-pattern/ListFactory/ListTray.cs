using AbstractFactory_pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_pattern.ListFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<li>\n");
            sb.Append($"{ caption }\n");
            sb.Append($"<ul>\n");
            var it = tray.GetEnumerator();
            while(it.MoveNext())
            {
                Item item = (Item)it.Current;
                sb.Append(item.MakeHtml());
            }
            sb.Append($"</ul>\n");
            sb.Append($"</li>\n");
            return sb.ToString();
        }
    }
}
