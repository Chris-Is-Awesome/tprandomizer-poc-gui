

namespace TPRandomizer
{ 
    public class Singleton
    {
        public ItemFunctions Items = new ItemFunctions();
        public CheckFunctions Checks = new CheckFunctions();
        public RoomFunctions Rooms = new RoomFunctions();

        public LogicFunctions Logic = new LogicFunctions();
        public Randomizer Randomizer = new Randomizer();

        private static Singleton instance;
        
        
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}