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
                    Name = "Marina Beach",
                    Location = "Chennai",
                    Description = "One of the longest urban beaches in the world, perfect for evening walks and local street food.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 2,
                    Name = "Taj Mahal",
                    Location = "Agra",
                    Description = "Iconic white marble mausoleum, one of the Seven Wonders of the World.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 3,
                    Name = "Gateway of India",
                    Location = "Mumbai",
                    Description = "Historic arch monument overlooking the Arabian Sea, built during British rule.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 4,
                    Name = "Hawa Mahal",
                    Location = "Jaipur",
                    Description = "Palace of Winds, five-story structure with unique honeycomb design and 953 small windows.",
                    Quality = "Good",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 5,
                    Name = "Meenakshi Temple",
                    Location = "Madurai",
                    Description = "Historic Hindu temple dedicated to Meenakshi, featuring stunning Dravidian architecture.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 6,
                    Name = "Goa Beaches",
                    Location = "Goa",
                    Description = "Beautiful tropical beaches with water sports, nightlife, and Portuguese heritage.",
                    Quality = "Good",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 7,
                    Name = "Kerala Backwaters",
                    Location = "Alleppey",
                    Description = "Network of lagoons and lakes with houseboat cruises through scenic waterways.",
                    Quality = "Excellent",
                    IsAvailable = true
                },
                new TouristSpot
                {
                    Id = 8,
                    Name = "Red Fort",
                    Location = "Delhi",
                    Description = "Massive red sandstone fort complex built by Mughal emperor Shah Jahan.",
                    Quality = "Good",
                    IsAvailable = false
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Grand Plaza Hotel",
                    Location = "Mumbai",
                    Description = "Luxury 5-star hotel with sea view rooms, rooftop restaurant, and spa facilities.",
                    Price = 5500,
                    Quality = "5-Star",
                    Availability = 25
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Taj Palace",
                    Location = "Delhi",
                    Description = "Premium hotel near India Gate with conference halls and fine dining.",
                    Price = 6200,
                    Quality = "5-Star",
                    Availability = 18
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Beach View Inn",
                    Location = "Chennai",
                    Description = "Comfortable beachfront hotel with modern amenities and seafood restaurant.",
                    Price = 3200,
                    Quality = "4-Star",
                    Availability = 32
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Heritage Hotel",
                    Location = "Jaipur",
                    Description = "Converted palace hotel with traditional Rajasthani decor and cultural performances.",
                    Price = 4800,
                    Quality = "4-Star",
                    Availability = 15
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Coastal Retreat",
                    Location = "Goa",
                    Description = "Resort-style hotel with pool, beach access, and water sports facilities.",
                    Price = 4200,
                    Quality = "4-Star",
                    Availability = 28
                },
                new Hotel
                {
                    Id = 6,
                    Name = "City Center Lodge",
                    Location = "Bangalore",
                    Description = "Budget-friendly hotel in city center with basic amenities and free WiFi.",
                    Price = 1800,
                    Quality = "Budget",
                    Availability = 42
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Mountain View Hotel",
                    Location = "Shimla",
                    Description = "Hill station hotel with panoramic mountain views and cozy fireplace rooms.",
                    Price = 3500,
                    Quality = "3-Star",
                    Availability = 20
                }
            );

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Spice Garden",
                    Location = "Mumbai",
                    Description = "Authentic Indian cuisine with North and South Indian specialties, tandoor dishes.",
                    Price = 800,
                    Quality = "Premium",
                    Availability = 50
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Coastal Kitchen",
                    Location = "Chennai",
                    Description = "Fresh seafood restaurant specializing in coastal delicacies and traditional recipes.",
                    Price = 650,
                    Quality = "Premium",
                    Availability = 40
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Royal Dine",
                    Location = "Jaipur",
                    Description = "Rajasthani royal cuisine in heritage ambiance with live folk music.",
                    Price = 950,
                    Quality = "Premium",
                    Availability = 35
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "Goan Shack",
                    Location = "Goa",
                    Description = "Beachside restaurant serving Goan fish curry, vindaloo, and Portuguese pastries.",
                    Price = 550,
                    Quality = "Standard",
                    Availability = 60
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "Street Food Hub",
                    Location = "Delhi",
                    Description = "Popular street food court offering chaat, momos, kebabs, and regional snacks.",
                    Price = 250,
                    Quality = "Budget",
                    Availability = 100
                },
                new Restaurant
                {
                    Id = 6,
                    Name = "Kerala Kitchen",
                    Location = "Kochi",
                    Description = "Traditional Kerala cuisine with appam, stew, fish moilee, and sadya meals.",
                    Price = 450,
                    Quality = "Standard",
                    Availability = 45
                },
                new Restaurant
                {
                    Id = 7,
                    Name = "Fusion Bistro",
                    Location = "Bangalore",
                    Description = "Modern fusion restaurant blending Indian and continental flavors.",
                    Price = 750,
                    Quality = "Premium",
                    Availability = 38
                }
            );

            modelBuilder.Entity<Resort>().HasData(
                new Resort
                {
                    Id = 1,
                    Name = "Ocean Paradise Resort",
                    Location = "Goa",
                    Description = "Luxury beachfront resort with private villas, infinity pool, spa, and water sports.",
                    Price = 8500,
                    Quality = "Luxury",
                    Availability = 15,
                    Capacity = 120
                },
                new Resort
                {
                    Id = 2,
                    Name = "Backwater Bliss Resort",
                    Location = "Alleppey",
                    Description = "Eco-resort on backwaters with houseboat stays, Ayurvedic spa, and yoga sessions.",
                    Price = 6500,
                    Quality = "Premium",
                    Availability = 22,
                    Capacity = 80
                },
                new Resort
                {
                    Id = 3,
                    Name = "Hill Station Retreat",
                    Location = "Ooty",
                    Description = "Mountain resort with cottages, bonfire evenings, trekking, and tea plantation tours.",
                    Price = 5200,
                    Quality = "Premium",
                    Availability = 18,
                    Capacity = 60
                },
                new Resort
                {
                    Id = 4,
                    Name = "Desert Safari Resort",
                    Location = "Jaisalmer",
                    Description = "Desert camp experience with camel safari, cultural programs, and traditional Rajasthani hospitality.",
                    Price = 4800,
                    Quality = "Standard",
                    Availability = 25,
                    Capacity = 100
                },
                new Resort
                {
                    Id = 5,
                    Name = "Wildlife Adventure Resort",
                    Location = "Jim Corbett",
                    Description = "Nature resort near national park with jungle safaris, bird watching, and campfires.",
                    Price = 7200,
                    Quality = "Premium",
                    Availability = 12,
                    Capacity = 50
                },
                new Resort
                {
                    Id = 6,
                    Name = "Island Paradise Resort",
                    Location = "Andaman",
                    Description = "Tropical island resort with scuba diving, snorkeling, beach activities, and coral reef tours.",
                    Price = 9500,
                    Quality = "Luxury",
                    Availability = 8,
                    Capacity = 40
                }
            );

            modelBuilder.Entity<TravelInfo>().HasData(
                new TravelInfo
                {
                    Id = 1,
                    TransportType = "Train",
                    Route = "Mumbai to Goa (Konkan Railway)",
                    Description = "Scenic train journey through Western Ghats. Daily service, AC and sleeper coaches available. Duration: 12 hours.",
                    Price = 850,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 2,
                    TransportType = "Flight",
                    Route = "Delhi to Mumbai",
                    Description = "Multiple daily flights by major carriers. Flight duration: 2.5 hours. Economy and business class available.",
                    Price = 4500,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 3,
                    TransportType = "Bus",
                    Route = "Bangalore to Mysore",
                    Description = "Luxury Volvo AC buses running every hour. Comfortable seating, onboard entertainment. Duration: 3.5 hours.",
                    Price = 450,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 4,
                    TransportType = "Train",
                    Route = "Delhi to Jaipur (Shatabdi Express)",
                    Description = "Premium express train with meals included. Comfortable AC chairs. Duration: 4.5 hours.",
                    Price = 750,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 5,
                    TransportType = "Ferry",
                    Route = "Mumbai to Elephanta Caves",
                    Description = "Ferry service from Gateway of India. Scenic boat ride. Duration: 1 hour one way.",
                    Price = 200,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 6,
                    TransportType = "Bus",
                    Route = "Chennai to Pondicherry",
                    Description = "Regular bus service along East Coast Road. Semi-sleeper and seater options. Duration: 3 hours.",
                    Price = 350,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 7,
                    TransportType = "Flight",
                    Route = "Chennai to Kolkata",
                    Description = "Daily flights connecting South and East India. Duration: 2 hours. Multiple time slots.",
                    Price = 5200,
                    Availability = true
                },
                new TravelInfo
                {
                    Id = 8,
                    TransportType = "Train",
                    Route = "Kochi to Trivandrum",
                    Description = "Kerala coastal train with beautiful Arabian Sea views. Duration: 4 hours.",
                    Price = 280,
                    Availability = false
                }
            );
        }
    }
}
