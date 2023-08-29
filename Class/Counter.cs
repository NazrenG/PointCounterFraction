

namespace Step_cs.Class
{
    internal class Counter
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int CurrentData { get; set; }

        public Counter()
        {
            Min = 0;
            Max = 0;
            CurrentData = 0;
        }

        public Counter(int min, int max)
        {
            Min = min;
            Max = max;
            CurrentData = min;

        }
        public void Increment()
        {
            if (CurrentData == Max)
                CurrentData = Min;
            else CurrentData += 1;

        }
        public void Decrement()
        {
            if (CurrentData == Min)
                CurrentData = Max;

            else --CurrentData;

        }
        public void GetCurrent()
        {
            Console.WriteLine(CurrentData);
        }
    }
}
