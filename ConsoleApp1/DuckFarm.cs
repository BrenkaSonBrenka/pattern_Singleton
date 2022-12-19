namespace ConsoleApp1
{
    class DuckFarm
    {
        static object locker = new();
        private static DuckFarm duckfurm;
        private Duck[] ducks;
        static int count;
        public static int Count
        {
            get { return count; }
            protected set { count = value; }
        }
        private DuckFarm() 
        {
            count++;
        }
        public static DuckFarm Get() 
        {
            if (duckfurm == null)
            {
                lock (locker) 
                {
                    if(duckfurm == null) 
                    {
                        duckfurm= new DuckFarm();
                    }
                }
            }
            return duckfurm;
        }
        public void Add(Duck[] ducks)
        {
            this.ducks = ducks;
        }
        public void Show() 
        {
            Console.WriteLine("Утки:");
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.name);
            }
        }
    }
}
