using System;
using System.Collections.Generic;

namespace Interpreter_pattern
{
    public class CommandListNode : Node
    {
        private List<Node> list = new List<Node>();
        public override void Parse(Context context)
        {
            while(true)
            {
                if(context.CurrentToken() is null)
                {
                    throw new Exception("parsed error!");
                }
                else if (context.CurrentToken().Equals("end"))
                {
                    context.SkipToken("end");
                    break;
                }
                else
                {
                    Node commandNode = new CommandNode();
                    commandNode.Parse(context);
                    list.Add(commandNode);
                }
            }
        }
        public override string ToString()
        {
            return string.Join(",", list);
        }
    }
}
