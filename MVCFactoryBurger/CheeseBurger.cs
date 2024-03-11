namespace MVCFactoryBurger
{
    internal class CheeseBurger : IBurger
    {

        public string getBun()
        {
            return "Wheat";
        }
        public string getCondiments()
        {
            return "CHEESE, CHEESE, CHEESE!";
        }
        public string getPatty()
        {
            return "Beef";
        }

    }
}
