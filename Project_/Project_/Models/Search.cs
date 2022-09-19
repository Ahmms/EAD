namespace Project_.Models
{
    public class Search
    {
        public string city { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string min_price { get; set; }
        public string max_price { get; set; }
        
    }
    public class Search_function
    {
        public List<AdsDatum> ads(Search s)
        {
            List<AdsDatum> adsList = new List<AdsDatum>();
            if (s.city == "null" && s.make == "null" && s.model == "null" && s.min_price == "null" && s.max_price == "null")
            {
                var Db = new ProjectContext();
                var All_ads = Db.AdsData;
                foreach (var ad in All_ads)
                {
                    adsList.Add(ad);
                }
            }
            return adsList;
        }
    }
}
