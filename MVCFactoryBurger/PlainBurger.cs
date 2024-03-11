namespace MVCFactoryBurger
{
    internal class PlainBurger : IBurger
    {

        public string getBun()
        {
            return "Wheat";
        }
        public string getCondiments()
        {
            return "Tomato sauce";
        }
        public string getPatty()
        {
            return "Beef";
        }

    }
}
