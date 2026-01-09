using Microsoft.EntityFrameworkCore;
using karnel_travels_mvc.Models;

namespace karnel_travels_mvc.Data
{
    public class KarnelTravelContext : DbContext
    {
        public KarnelTravelContext(DbContextOptions<KarnelTravelContext> options)
            : base(options)
        {
        }

        public DbSet<TouristSpot> TouristSpots { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Resort> Resorts { get; set; }

        public DbSet<TravelInfo> TravelInfos { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TouristSpot>().HasData(
                new TouristSpot
                {
                    Id = 1,
                    Name = "Hunza Valley",
                    Location = "Gilgit-Baltistan",
                    Description = "Famous for snow-capped mountains, Attabad Lake, and breathtaking landscapes.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 2,
                    Name = "Badshahi Mosque",
                    Location = "Lahore",
                    Description = "One of the largest historic mosques in the world, built during the Mughal era.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 3,
                    Name = "Faisal Mosque",
                    Location = "Islamabad",
                    Description = "Iconic modern mosque at the foothills of Margalla Hills.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 4,
                    Name = "Murree Hills",
                    Location = "Murree",
                    Description = "Popular hill station known for cool climate, chairlifts, and scenic views.",
                    Quality = "Good",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 5,
                    Name = "Mohatta Palace",
                    Location = "Karachi",
                    Description = "Historic palace showcasing art exhibitions and Sindh heritage.",
                    Quality = "Good",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 6,
                    Name = "Skardu",
                    Location = "Gilgit-Baltistan",
                    Description = "Gateway to K2 and famous for lakes, forts, and trekking routes.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 7,
                    Name = "Derawar Fort",
                    Location = "Bahawalpur",
                    Description = "Massive square fort in Cholistan Desert with rich Nawabi history.",
                    Quality = "Good",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 8,
                    Name = "Makli Necropolis",
                    Location = "Thatta",
                    Description = "UNESCO World Heritage site with one of the largest graveyards in the world.",
                    Quality = "Good",
                    IsAvailable = false
                },

                    new TouristSpot
                    {
                        Id = 9,
                        Name = "Lahore Fort",
                        Location = "Lahore",
                        Description = "Historic Mughal fort adjacent to Badshahi Mosque.",
                        Quality = "Excellent",
                        IsAvailable = true
                    },
    new TouristSpot
    {
        Id = 10,
        Name = "Minar-e-Pakistan",
        Location = "Lahore",
        Description = "National monument where Pakistan Resolution was passed.",
        Quality = "Excellent",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 11,
        Name = "Wazir Khan Mosque",
        Location = "Lahore",
        Description = "17th century Mughal mosque famous for its frescoes.",
        Quality = "Excellent",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 12,
        Name = "Clifton Beach",
        Location = "Karachi",
        Description = "Popular city beach on the Arabian Sea, known for camel rides and food stalls.",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 13,
        Name = "Mazar-e-Quaid",
        Location = "Karachi",
        Description = "Mausoleum of Quaid-e-Azam Muhammad Ali Jinnah, an iconic Karachi landmark.",
        Quality = "Excellent",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 14,
        Name = "Pakistan Monument",
        Location = "Islamabad",
        Description = "National monument symbolizing Pakistan’s unity (foothills of Margalla).",
        Quality = "Excellent",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 15,
        Name = "Daman-e-Koh",
        Location = "Islamabad",
        Description = "Hilltop park with panoramic views of Islamabad city.",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 16,
        Name = "Lok Virsa Heritage Museum",
        Location = "Islamabad",
        Description = "Cultural museum showcasing Pakistan’s diverse traditions.",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 17,
        Name = "Baltit Fort",
        Location = "Gilgit-Baltistan",
        Description = "8th-century fort overlooking Karimabad in Hunza Valley.",
        Quality = "Excellent",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 18,
        Name = "Passu Cones",
        Location = "Gilgit-Baltistan",
        Description = "Distinctive jagged peaks along the Karakoram Highway in Hunza.",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 19,
        Name = "Attabad Lake",
        Location = "Gilgit-Baltistan",
        Description = "Scenic turquoise lake in Hunza (formed by 2010 landslide).",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 20,
        Name = "Deosai National Park",
        Location = "Gilgit-Baltistan",
        Description = "High-altitude plateau (Land of Giants) near Skardu, famed for wildflowers.",
        Quality = "Excellent",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 21,
        Name = "Satpara Lake",
        Location = "Gilgit-Baltistan",
        Description = "Mountain lake near Skardu supplying fresh water to the valley.",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 22,
        Name = "Malam Jabba",
        Location = "Swat",
        Description = "Mountain resort and ski area in Swat Valley.",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 23,
        Name = "Mahodand Lake",
        Location = "Swat",
        Description = "Alpine lake in the Ushu Valley of Swat (fishing & boating).",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 24,
        Name = "Ushu Forest",
        Location = "Swat",
        Description = "Cedar forest in Swat, gateway to Mahodand Lake.",
        Quality = "Good",
        IsAvailable = true
    },
    new TouristSpot
    {
        Id = 25,
        Name = "Swat Museum",
        Location = "Swat",
        Description = "Archaeological museum in Saidu Sharif, showcasing Gandharan artifacts.",
        Quality = "Standard",
        IsAvailable = true
    }
            );


            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Pearl Continental Hotel",
                    Location = "Lahore",
                    Description = "Luxury hotel near Mall Road with fine dining and conference halls.",
                    Price = 22000,
                    Quality = "5-Star",
                    Availability = 20
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Serena Hotel",
                    Location = "Islamabad",
                    Description = "Premium hotel offering traditional architecture and luxury services.",
                    Price = 26000,
                    Quality = "5-Star",
                    Availability = 15
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Avari Towers",
                    Location = "Karachi",
                    Description = "Business-class hotel in city center with rooftop dining.",
                    Price = 18000,
                    Quality = "5-Star",
                    Availability = 25
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Hotel One",
                    Location = "Faisalabad",
                    Description = "Comfortable mid-range hotel with modern amenities.",
                    Price = 9000,
                    Quality = "3-Star",
                    Availability = 30
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Hunza View Hotel",
                    Location = "Hunza",
                    Description = "Mountain-view hotel popular with tourists and trekkers.",
                    Price = 7500,
                    Quality = "3-Star",
                    Availability = 18
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Shelton Guest House",
                    Location = "Quetta",
                    Description = "Affordable stay with basic facilities for travelers.",
                    Price = 5500,
                    Quality = "Budget",
                    Availability = 35
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Shangrila Resort Hotel",
                    Location = "Skardu",
                    Description = "Famous resort hotel near Lower Kachura Lake.",
                    Price = 16000,
                    Quality = "4-Star",
                    Availability = 12
                }
            ,
                   new Hotel
                   {
                       Id = 8,
                       Name = "Islamabad Marriott Hotel",
                       Location = "Islamabad",
                       Description = "Luxury hotel in Islamabad with modern amenities.",
                       Price = 23000,
                       Quality = "5-Star",
                       Availability = 20
                   },
    new Hotel
    {
        Id = 9,
        Name = "Avari Towers Lahore",
        Location = "Lahore",
        Description = "Luxury hotel on Mall Road with historic charm.",
        Price = 20000,
        Quality = "5-Star",
        Availability = 18
    },
    new Hotel
    {
        Id = 10,
        Name = "Pearl Continental Rawalpindi",
        Location = "Rawalpindi",
        Description = "5-star hotel serving Islamabad/Rawalpindi area.",
        Price = 22000,
        Quality = "5-Star",
        Availability = 15
    },
    new Hotel
    {
        Id = 11,
        Name = "Karachi Marriott Hotel",
        Location = "Karachi",
        Description = "Downtown luxury hotel with international brand.",
        Price = 25000,
        Quality = "5-Star",
        Availability = 18
    },
    new Hotel
    {
        Id = 12,
        Name = "Hilton Karachi",
        Location = "Karachi",
        Description = "Modern hotel in Clifton area with upscale dining.",
        Price = 18000,
        Quality = "5-Star",
        Availability = 22
    },
    new Hotel
    {
        Id = 13,
        Name = "Serena Inn Hunza",
        Location = "Hunza",
        Description = "Boutique hotel in Karimabad with mountain views.",
        Price = 12000,
        Quality = "3-Star",
        Availability = 25
    },
    new Hotel
    {
        Id = 14,
        Name = "Eagle’s Nest Hotel",
        Location = "Hunza",
        Description = "Popular hotel near Duikar with panoramic Hunza valley views.",
        Price = 15000,
        Quality = "4-Star",
        Availability = 20
    },
    new Hotel
    {
        Id = 15,
        Name = "Serena Shigar Fort",
        Location = "Skardu",
        Description = "Heritage hotel in a restored fort near Skardu.",
        Price = 22000,
        Quality = "Luxury",
        Availability = 12
    },
    new Hotel
    {
        Id = 16,
        Name = "Pearl Continental Swat (Madyan)",
        Location = "Swat",
        Description = "5-star hill resort near Madyan with ski facilities.",
        Price = 20000,
        Quality = "5-Star",
        Availability = 10
    },
    new Hotel
    {
        Id = 17,
        Name = "Swat Continental Hotel",
        Location = "Swat",
        Description = "Mid-range hotel in Swat Valley with modern amenities.",
        Price = 8000,
        Quality = "3-Star",
        Availability = 30
    },
    new Hotel
    {
        Id = 18,
        Name = "Serena Hotel Malam Jabba",
        Location = "Swat",
        Description = "Luxury mountain resort at Malam Jabba ski area.",
        Price = 15000,
        Quality = "5-Star",
        Availability = 14
    }

);


            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Monal",
                    Location = "Islamabad",
                    Description = "Famous hilltop restaurant offering Pakistani and continental cuisine.",
                    Price = 1800,
                    Quality = "Premium",
                    Availability = 60
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Haveli Restaurant",
                    Location = "Lahore",
                    Description = "Traditional Pakistani food with Badshahi Mosque view.",
                    Price = 1500,
                    Quality = "Premium",
                    Availability = 45
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Kolachi",
                    Location = "Karachi",
                    Description = "Popular seaside restaurant known for BBQ and seafood.",
                    Price = 1700,
                    Quality = "Premium",
                    Availability = 70
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "Student Biryani",
                    Location = "Karachi",
                    Description = "Iconic biryani spot famous nationwide.",
                    Price = 450,
                    Quality = "Budget",
                    Availability = 100
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "Cafe Islamabad",
                    Location = "Islamabad",
                    Description = "Casual dining with desi and Chinese menu.",
                    Price = 900,
                    Quality = "Standard",
                    Availability = 40
                },
                new Restaurant
                {
                    Id = 6,
                    Name = "Usmania Restaurant",
                    Location = "Lahore",
                    Description = "Well-known for traditional desi breakfast and karahi.",
                    Price = 600,
                    Quality = "Standard",
                    Availability = 55
                },
                new Restaurant
                {
                    Id = 7,
                    Name = "Cafe De Hunza",
                    Location = "Hunza",
                    Description = "Local cafe serving organic Hunza food and desserts.",
                    Price = 800,
                    Quality = "Standard",
                    Availability = 30
                },
                  new Restaurant
                  {
                      Id = 8,
                      Name = "Butt Karahi",
                      Location = "Lahore",
                      Description = "Famous for spicy karahi dishes in Lahore.",
                      Price = 600,
                      Quality = "Standard",
                      Availability = 50
                  },
    new Restaurant
    {
        Id = 9,
        Name = "Cooco's Den",
        Location = "Lahore",
        Description = "Popular restaurant with Lahore Fort views.",
        Price = 1200,
        Quality = "Premium",
        Availability = 30
    },
    new Restaurant
    {
        Id = 10,
        Name = "Tuscany Courtyard",
        Location = "Islamabad",
        Description = "Outdoor Italian restaurant in F-6 area.",
        Price = 2000,
        Quality = "Premium",
        Availability = 25
    },
    new Restaurant
    {
        Id = 11,
        Name = "Burning Brownie",
        Location = "Islamabad",
        Description = "Coffee shop and bakery known for desserts.",
        Price = 800,
        Quality = "Standard",
        Availability = 35
    },
    new Restaurant
    {
        Id = 12,
        Name = "Okra",
        Location = "Karachi",
        Description = "Upscale Mediterranean restaurant in Clifton.",
        Price = 2500,
        Quality = "Premium",
        Availability = 40
    },
    new Restaurant
    {
        Id = 13,
        Name = "BBQ Tonight",
        Location = "Karachi",
        Description = "Well-known BBQ and grill restaurant in Clifton.",
        Price = 1700,
        Quality = "Premium",
        Availability = 60
    },
    new Restaurant
    {
        Id = 14,
        Name = "Xander's",
        Location = "Karachi",
        Description = "Contemporary cafe and restaurant in Clifton.",
        Price = 1800,
        Quality = "Premium",
        Availability = 30
    },
    new Restaurant
    {
        Id = 15,
        Name = "Amber Cafe",
        Location = "Hunza",
        Description = "Popular cafe in Karimabad serving local Hunza dishes.",
        Price = 800,
        Quality = "Standard",
        Availability = 20
    },
    new Restaurant
    {
        Id = 16,
        Name = "Peach Hotel Restaurant",
        Location = "Swat",
        Description = "Alpine-style restaurant at Malam Jabba resort.",
        Price = 1000,
        Quality = "Standard",
        Availability = 15
    }

            );


            modelBuilder.Entity<Resort>().HasData(
                new Resort
                {
                    Id = 1,
                    Name = "Shangrila Resort",
                    Location = "Skardu",
                    Description = "Famous red-roof resort near Lower Kachura Lake.",
                    Price = 20000,
                    Quality = "Luxury",
                    Availability = 10,
                    Capacity = 90
                },
                new Resort
                {
                    Id = 2,
                    Name = "Serena Khaplu Palace",
                    Location = "Khaplu",
                    Description = "Restored heritage palace offering luxury stays.",
                    Price = 24000,
                    Quality = "Luxury",
                    Availability = 6,
                    Capacity = 40
                },
                new Resort
                {
                    Id = 3,
                    Name = "Arcadian Riverside",
                    Location = "Naran",
                    Description = "Scenic riverside resort popular among families.",
                    Price = 14000,
                    Quality = "Premium",
                    Availability = 14,
                    Capacity = 70
                },
                new Resort
                {
                    Id = 4,
                    Name = "Green Retreat",
                    Location = "Swat",
                    Description = "Nature resort surrounded by mountains and rivers.",
                    Price = 11000,
                    Quality = "Standard",
                    Availability = 20,
                    Capacity = 85
                },
                new Resort
                {
                    Id = 5,
                    Name = "Ziarat Residency Resort",
                    Location = "Ziarat",
                    Description = "Peaceful resort near Quaid-e-Azam Residency.",
                    Price = 9000,
                    Quality = "Standard",
                    Availability = 16,
                    Capacity = 60
                },
                new Resort
                {
                    Id = 6,
                    Name = "Beach Luxury Resort",
                    Location = "Gwadar",
                    Description = "Coastal resort offering sea views and private cottages.",
                    Price = 17000,
                    Quality = "Luxury",
                    Availability = 8,
                    Capacity = 50
                },
                 new Resort
                 {
                     Id = 7,
                     Name = "Swat Serena Resort",
                     Location = "Malam Jabba",
                     Description = "Luxury mountain resort with ski facilities in Swat.",
                     Price = 25000,
                     Quality = "Luxury",
                     Availability = 8,
                     Capacity = 70
                 },
    new Resort
    {
        Id = 8,
        Name = "Pearl Continental Resort Naran",
        Location = "Naran",
        Description = "High-end hill resort overlooking the Kunhar River.",
        Price = 22000,
        Quality = "Luxury",
        Availability = 10,
        Capacity = 60
    },
    new Resort
    {
        Id = 9,
        Name = "Fairy Meadows Resort",
        Location = "Nanga Parbat Basecamp",
        Description = "Remote resort at the base of Nanga Parbat (Fairy Meadows).",
        Price = 8000,
        Quality = "Standard",
        Availability = 20,
        Capacity = 50
    },
    new Resort
    {
        Id = 10,
        Name = "Jungle Resort Naltar",
        Location = "Naltar",
        Description = "Eco-resort surrounded by forests near Gilgit.",
        Price = 9000,
        Quality = "Standard",
        Availability = 15,
        Capacity = 40
    }

            );


            modelBuilder.Entity<TravelInfo>().HasData(
                new TravelInfo
                {
                    Id = 1,
                    TransportType = "Flight",
                    Route = "Karachi to Islamabad",
                    Description = "Daily flights by PIA and private airlines. Duration: 2 hours.",
                    Price = 22000,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 2,
                    TransportType = "Train",
                    Route = "Lahore to Karachi (Green Line)",
                    Description = "Modern express train with AC coaches. Duration: 18 hours.",
                    Price = 6500,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 3,
                    TransportType = "Bus",
                    Route = "Islamabad to Murree",
                    Description = "Luxury coach service with frequent departures.",
                    Price = 600,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 4,
                    TransportType = "Bus",
                    Route = "Lahore to Faisalabad",
                    Description = "Comfortable Daewoo bus service. Duration: 3 hours.",
                    Price = 1200,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 5,
                    TransportType = "Flight",
                    Route = "Islamabad to Skardu",
                    Description = "Weather-dependent scenic flight over mountains.",
                    Price = 26000,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 6,
                    TransportType = "Bus",
                    Route = "Karachi to Hyderabad",
                    Description = "Hourly bus service via Super Highway.",
                    Price = 900,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 7,
                    TransportType = "Train",
                    Route = "Rawalpindi to Peshawar",
                    Description = "Intercity rail service. Duration: 4 hours.",
                    Price = 1500,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 8,
                    TransportType = "Jeep",
                    Route = "Skardu to Deosai Plains",
                    Description = "4x4 jeep service for high-altitude national park.",
                    Price = 8000,
                    Availability = false
                },
                  new TravelInfo
                  {
                      Id = 9,
                      TransportType = "Flight",
                      Route = "Karachi to Lahore",
                      Description = "Daily flights (PIA/SereneAir). Duration ~1h45.",
                      Price = 10000,
                      Availability = true
                  },
    new TravelInfo
    {
        Id = 10,
        TransportType = "Train",
        Route = "Lahore to Peshawar",
        Description = "Express train (Awam/Jaffar Express). Duration ~6h.",
        Price = 1800,
        Availability = true
    },
    new TravelInfo
    {
        Id = 11,
        TransportType = "Bus",
        Route = "Islamabad to Peshawar",
        Description = "Daewoo Express bus service. Duration ~2h30m.",
        Price = 1500,
        Availability = true
    }

            );

        }
    }
}
