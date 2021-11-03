using System;

namespace Interpreter_pattern
{
    public class RepeatCommandNode : Node
    {
        private int number;
        private Node commandListNode;
        public override void Parse(Context context)
        {
            context.SkipToken("repeat");
            number = Convert.ToInt32(context.CurrentToken());
            context.NextToken();
            commandListNode = new CommandListNode();
            commandListNode.Parse(context);
        }
        public override string ToString()
        {
            return$"[repeat {number} {commandListNode}]";
        }
    }
}
