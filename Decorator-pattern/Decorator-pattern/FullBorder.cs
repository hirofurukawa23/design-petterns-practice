using System.Text;

namespace Decorator_pattern
{
    public class FullBorder : Border
    {
        public FullBorder(Display display):base(display)
        {
        }

        public override int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if(row.Equals(0))
            {
                return $"+{ MakeLine('-', display.GetColumns()) }+";
            }
            else if (row.Equals(display.GetRows() + 1))
            {
                return $"+{ MakeLine('-', display.GetColumns()) }+";
            }
            else
            {
                return $"|{ display.GetRowText(row - 1) }|";
            }
        }

        private object MakeLine(char ch, int count)
        {
            StringBuilder sb = new StringBuilder();
            for(var i = 0; i < count; i++)
            {
                sb.Append(ch);
            }
            return sb.ToString();
        }
    }
}
