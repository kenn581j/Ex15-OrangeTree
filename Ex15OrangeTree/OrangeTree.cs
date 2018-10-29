using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15OrangeTree
{
    public class OrangeTree
    {
        public OrangeTree(int inAge, int inHeight)
        {
            Age = inAge;
            Height = inHeight;
        }

        public int Age
        {
            get;
            private set;
        }
        public int Height
        {
            get;
            private set;
        }
        public bool TreeAlive
        {
            get;
            private set;
        }
        public int NumOranges
        {
            get;
            private set;
        }
        public int OrangesEaten
        {
            get;
            private set;
        }

        public void OneYearPasses()
        {
            Age += 1;

            if (Age < 80)
            {
                Height += 2;
            }
            
            if (Age > 1 & Age < 80)
            {
                NumOranges += 5;
            }
            else if (Age > 80)
            {
                NumOranges = 0;
            }

            OrangesEaten = 0;
        }

        public void EatOrange(int v)
        {            
            if (NumOranges > 0)
            {
                OrangesEaten += v;
            }
            else
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
        }
    }
}
