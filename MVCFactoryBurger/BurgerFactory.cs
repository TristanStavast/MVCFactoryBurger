namespace MVCFactoryBurger
{
    public class BurgerFactory
    {

        public IBurger? returnInstance;

        public IBurger getBurger(string burgerType)
        {

            if (burgerType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenBurger();
            }
            else if (burgerType.ToLower().Equals("fish"))
            {
                returnInstance = new FishBurger();
            }
            else if (burgerType.ToLower().Equals("cheese"))
            {
                returnInstance = new CheeseBurger();
            }
            else
            {
                returnInstance = new PlainBurger();
            }
            return returnInstance;

        }

    }
}
