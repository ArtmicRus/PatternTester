using ProxyPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace ProxyPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class SiteProxy : ISite
    {
        private ISite site;
        private Dictionary<int, string> cache;

        public SiteProxy(ISite site)
        {
            this.site = site;
            this.cache = new Dictionary<int, string>();
        }

        public string GetPage(int pageIndex)
        {
            string page;
            if (cache.ContainsKey(pageIndex))
            {
                page = cache[pageIndex];
                page = "Из кэша " + page;
            }
            else
            {
                page = site.GetPage(pageIndex);
                cache.Add(pageIndex, page);
            }
            return page;
        }
    }
}
