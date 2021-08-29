using System.Collections.Generic;

namespace Builder_pattern
{
    public abstract class Builder
    {
        public abstract void MakeTitle(string title);

        public abstract void MakeString(string str);

        public abstract void MakeItems(List<string> items);

        public abstract void Close();
    }
}
