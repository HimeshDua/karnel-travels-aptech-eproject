namespace karnel_travels_mvc.Models
{
    public class SearchViewModel
    {
        public List<TouristSpot> TouristSpots { get; set; } = new List<TouristSpot>();
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
        public List<Resort> Resorts { get; set; } = new List<Resort>();
        public int TotalResults => TouristSpots.Count + Hotels.Count + Restaurants.Count + Resorts.Count;
        public bool HasResults => TotalResults > 0;
    }
}
