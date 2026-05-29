namespace drinks_info
{
    //ServiceFactory.cs - Ansvarig för att skapa och konfigurera tjänster, denna klass följer Factory Pattern för att enkelt kunna skapa instanser av tjänster
    //det gör det lätt att byta implementationer senare (t.ex. för testing)
    public static class ServiceFactory
    {
        //skapar och returnerar en instans av DrinksService
        public static DrinksService CreateDrinksService()
        {
            return new DrinksService();
        }

        // Används för att initialisera applikationens tillstånd
        public static AppState CreateAppState()
        {
            return new AppState();
        }

    }
}
