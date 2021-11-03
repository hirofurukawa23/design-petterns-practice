using System.Text;

namespace Decorator_pattern
{
    public class StringDisplay : Display
    {
        private string str;
        public StringDisplay(string str)
        {
            this.str = str;
        }
        public override int GetColumns()
        {
            return Encoding.GetEncoding("Shift_JIS").GetBytes(str).Length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            return (row.Equals(0)) ? str : null;
        }
    }
}
