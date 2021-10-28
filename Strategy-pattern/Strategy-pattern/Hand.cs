using System;

namespace Strategy_pattern
{
    public class Hand
    {
        public static int HANDVALUE_ROCK = 0;
        public static int HANDVALUE_SCSSOR = 1;
        public static int HANDVALUE_PAPER = 2;
        public static Hand[] HandVals =
        {
            new Hand(HANDVALUE_ROCK),
            new Hand(HANDVALUE_SCSSOR),
            new Hand(HANDVALUE_PAPER),
        };
        private static string[] Name =
        {
            "グー", "チョキ", "パー"
        };

        internal static Hand GetHand(object r)
        {
            throw new NotImplementedException();
        }

        private int _handValue;
        private Hand(int handValue)
        {
            this._handValue = handValue;
        }
        public static Hand GetHand(int handValue)
        {
            return HandVals[handValue];
        }
        public bool IsStrongerThan(Hand h)
        {
            return fight(h) == 1;
        }
        public bool IsWeakerThan(Hand h)
        {
            return fight(h) == -1;
        }

        private int fight(Hand h)
        {
            if(this == h)
            {
                return 0;
            }
            else if ((this._handValue + 1) % 3 == h._handValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return Name[_handValue];
        }
    }
}
