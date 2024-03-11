namespace MVCFactoryBurger
{
    internal class ChickenBurger : IBurger
    {

        public string getBun()
        {
            return "French bread";
        }
        public string getCondiments()
        {
            return "Sweet-Chilli sauce";
        }
        public string getPatty()
        {
            return "Chicken";
        }

    }
}
