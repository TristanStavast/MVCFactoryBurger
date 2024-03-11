namespace MVCFactoryBurger
{
    internal class FishBurger : IBurger
    {

        public string getBun()
        {
            return "No bun";
        }
        public string getCondiments()
        {
            return "Ta-ta";
        }
        public string getPatty()
        {
            return "Fish";
        }

    }
}
