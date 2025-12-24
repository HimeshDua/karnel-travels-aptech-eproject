namespace karnel_travels_mvc.Models
{
    /// <summary>
    /// View model for search results page
    /// Aggregates search results from multiple entity types
    /// </summary>
    public class SearchViewModel
    {
        /// <summary>
        /// List of tourist spots matching search criteria
        /// </summary>
        public List<TouristSpot> TouristSpots { get; set; } = new List<TouristSpot>();

        /// <summary>
        /// List of hotels matching search criteria
        /// </summary>
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();

        /// <summary>
        /// List of restaurants matching search criteria
        /// </summary>
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

        /// <summary>
        /// List of resorts matching search criteria
        /// </summary>
        public List<Resort> Resorts { get; set; } = new List<Resort>();

        /// <summary>
        /// Total number of results across all categories
        /// </summary>
        public int TotalResults => TouristSpots.Count + Hotels.Count + Restaurants.Count + Resorts.Count;

        /// <summary>
        /// Indicates whether any results were found
        /// </summary>
        public bool HasResults => TotalResults > 0;
    }
}
