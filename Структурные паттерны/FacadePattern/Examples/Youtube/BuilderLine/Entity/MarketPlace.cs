namespace FacadePattern.Examples.Youtube.BuilderLine.Entity
{
    internal class MarketPlace
    {
        private ProviderCommunication _providerCommunication;
        private Site _site;
        private Database _database;

        public MarketPlace()
        {
            _providerCommunication = new();
            _site = new();
            _database = new();
        }

        public void ProductReceip()
        {
            _providerCommunication.Receive();
            _site.Placement();
            _database.Insert();
        }

        public void ProductRealise()
        {
            _providerCommunication.Payment();
            _site.Del();
            _database.Del();
        }
    }
}
