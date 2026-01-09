using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace karnel_travels_mvc.Migrations
{
    /// <inheritdoc />
    public partial class locationchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 20, "Luxury hotel near Mall Road with fine dining and conference halls.", "Lahore", "Pearl Continental Hotel", 22000m });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 15, "Premium hotel offering traditional architecture and luxury services.", "Islamabad", "Serena Hotel", 26000m });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 25, "Business-class hotel in city center with rooftop dining.", "Karachi", "Avari Towers", 18000m, "5-Star" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 30, "Comfortable mid-range hotel with modern amenities.", "Faisalabad", "Hotel One", 9000m, "3-Star" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 18, "Mountain-view hotel popular with tourists and trekkers.", "Hunza", "Hunza View Hotel", 7500m, "3-Star" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 35, "Affordable stay with basic facilities for travelers.", "Quetta", "Shelton Guest House", 5500m });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 12, "Famous resort hotel near Lower Kachura Lake.", "Skardu", "Shangrila Resort Hotel", 16000m, "4-Star" });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 10, 90, "Famous red-roof resort near Lower Kachura Lake.", "Skardu", "Shangrila Resort", 20000m });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 6, 40, "Restored heritage palace offering luxury stays.", "Khaplu", "Serena Khaplu Palace", 24000m, "Luxury" });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 14, 70, "Scenic riverside resort popular among families.", "Naran", "Arcadian Riverside", 14000m });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 20, 85, "Nature resort surrounded by mountains and rivers.", "Swat", "Green Retreat", 11000m });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 16, 60, "Peaceful resort near Quaid-e-Azam Residency.", "Ziarat", "Ziarat Residency Resort", 9000m, "Standard" });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 50, "Coastal resort offering sea views and private cottages.", "Gwadar", "Beach Luxury Resort", 17000m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 60, "Famous hilltop restaurant offering Pakistani and continental cuisine.", "Islamabad", "Monal", 1800m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 45, "Traditional Pakistani food with Badshahi Mosque view.", "Lahore", "Haveli Restaurant", 1500m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 70, "Popular seaside restaurant known for BBQ and seafood.", "Karachi", "Kolachi", 1700m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 100, "Iconic biryani spot famous nationwide.", "Karachi", "Student Biryani", 450m, "Budget" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 40, "Casual dining with desi and Chinese menu.", "Islamabad", "Cafe Islamabad", 900m, "Standard" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 55, "Well-known for traditional desi breakfast and karahi.", "Lahore", "Usmania Restaurant", 600m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 30, "Local cafe serving organic Hunza food and desserts.", "Hunza", "Cafe De Hunza", 800m, "Standard" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Famous for snow-capped mountains, Attabad Lake, and breathtaking landscapes.", "Gilgit-Baltistan", "Hunza Valley" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "One of the largest historic mosques in the world, built during the Mughal era.", "Lahore", "Badshahi Mosque" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Iconic modern mosque at the foothills of Margalla Hills.", "Islamabad", "Faisal Mosque" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Popular hill station known for cool climate, chairlifts, and scenic views.", "Murree", "Murree Hills" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Location", "Name", "Quality" },
                values: new object[] { "Historic palace showcasing art exhibitions and Sindh heritage.", "Karachi", "Mohatta Palace", "Good" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Location", "Name", "Quality" },
                values: new object[] { "Gateway to K2 and famous for lakes, forts, and trekking routes.", "Gilgit-Baltistan", "Skardu", "Excellent" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Location", "Name", "Quality" },
                values: new object[] { "Massive square fort in Cholistan Desert with rich Nawabi history.", "Bahawalpur", "Derawar Fort", "Good" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "UNESCO World Heritage site with one of the largest graveyards in the world.", "Thatta", "Makli Necropolis" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Daily flights by PIA and private airlines. Duration: 2 hours.", 22000m, "Karachi to Islamabad", "Flight" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Modern express train with AC coaches. Duration: 18 hours.", 6500m, "Lahore to Karachi (Green Line)", "Train" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price", "Route" },
                values: new object[] { "Luxury coach service with frequent departures.", 600m, "Islamabad to Murree" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Comfortable Daewoo bus service. Duration: 3 hours.", 1200m, "Lahore to Faisalabad", "Bus" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Weather-dependent scenic flight over mountains.", 26000m, "Islamabad to Skardu", "Flight" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Price", "Route" },
                values: new object[] { "Hourly bus service via Super Highway.", 900m, "Karachi to Hyderabad" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Intercity rail service. Duration: 4 hours.", 1500m, "Rawalpindi to Peshawar", "Train" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "4x4 jeep service for high-altitude national park.", 8000m, "Skardu to Deosai Plains", "Jeep" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 25, "Luxury 5-star hotel with sea view rooms, rooftop restaurant, and spa facilities.", "Mumbai", "Grand Plaza Hotel", 5500m });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 18, "Premium hotel near India Gate with conference halls and fine dining.", "Delhi", "Taj Palace", 6200m });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 32, "Comfortable beachfront hotel with modern amenities and seafood restaurant.", "Chennai", "Beach View Inn", 3200m, "4-Star" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 15, "Converted palace hotel with traditional Rajasthani decor and cultural performances.", "Jaipur", "Heritage Hotel", 4800m, "4-Star" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 28, "Resort-style hotel with pool, beach access, and water sports facilities.", "Goa", "Coastal Retreat", 4200m, "4-Star" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 42, "Budget-friendly hotel in city center with basic amenities and free WiFi.", "Bangalore", "City Center Lodge", 1800m });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 20, "Hill station hotel with panoramic mountain views and cozy fireplace rooms.", "Shimla", "Mountain View Hotel", 3500m, "3-Star" });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 15, 120, "Luxury beachfront resort with private villas, infinity pool, spa, and water sports.", "Goa", "Ocean Paradise Resort", 8500m });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 22, 80, "Eco-resort on backwaters with houseboat stays, Ayurvedic spa, and yoga sessions.", "Alleppey", "Backwater Bliss Resort", 6500m, "Premium" });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 18, 60, "Mountain resort with cottages, bonfire evenings, trekking, and tea plantation tours.", "Ooty", "Hill Station Retreat", 5200m });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 25, 100, "Desert camp experience with camel safari, cultural programs, and traditional Rajasthani hospitality.", "Jaisalmer", "Desert Safari Resort", 4800m });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Availability", "Capacity", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 12, 50, "Nature resort near national park with jungle safaris, bird watching, and campfires.", "Jim Corbett", "Wildlife Adventure Resort", 7200m, "Premium" });

            migrationBuilder.UpdateData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Location", "Name", "Price" },
                values: new object[] { 40, "Tropical island resort with scuba diving, snorkeling, beach activities, and coral reef tours.", "Andaman", "Island Paradise Resort", 9500m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 50, "Authentic Indian cuisine with North and South Indian specialties, tandoor dishes.", "Mumbai", "Spice Garden", 800m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 40, "Fresh seafood restaurant specializing in coastal delicacies and traditional recipes.", "Chennai", "Coastal Kitchen", 650m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 35, "Rajasthani royal cuisine in heritage ambiance with live folk music.", "Jaipur", "Royal Dine", 950m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 60, "Beachside restaurant serving Goan fish curry, vindaloo, and Portuguese pastries.", "Goa", "Goan Shack", 550m, "Standard" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 100, "Popular street food court offering chaat, momos, kebabs, and regional snacks.", "Delhi", "Street Food Hub", 250m, "Budget" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price" },
                values: new object[] { 45, "Traditional Kerala cuisine with appam, stew, fish moilee, and sadya meals.", "Kochi", "Kerala Kitchen", 450m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[] { 38, "Modern fusion restaurant blending Indian and continental flavors.", "Bangalore", "Fusion Bistro", 750m, "Premium" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "One of the longest urban beaches in the world, perfect for evening walks and local street food.", "Chennai", "Marina Beach" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Iconic white marble mausoleum, one of the Seven Wonders of the World.", "Agra", "Taj Mahal" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Historic arch monument overlooking the Arabian Sea, built during British rule.", "Mumbai", "Gateway of India" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Palace of Winds, five-story structure with unique honeycomb design and 953 small windows.", "Jaipur", "Hawa Mahal" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Location", "Name", "Quality" },
                values: new object[] { "Historic Hindu temple dedicated to Meenakshi, featuring stunning Dravidian architecture.", "Madurai", "Meenakshi Temple", "Excellent" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Location", "Name", "Quality" },
                values: new object[] { "Beautiful tropical beaches with water sports, nightlife, and Portuguese heritage.", "Goa", "Goa Beaches", "Good" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Location", "Name", "Quality" },
                values: new object[] { "Network of lagoons and lakes with houseboat cruises through scenic waterways.", "Alleppey", "Kerala Backwaters", "Excellent" });

            migrationBuilder.UpdateData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Massive red sandstone fort complex built by Mughal emperor Shah Jahan.", "Delhi", "Red Fort" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Scenic train journey through Western Ghats. Daily service, AC and sleeper coaches available. Duration: 12 hours.", 850m, "Mumbai to Goa (Konkan Railway)", "Train" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Multiple daily flights by major carriers. Flight duration: 2.5 hours. Economy and business class available.", 4500m, "Delhi to Mumbai", "Flight" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price", "Route" },
                values: new object[] { "Luxury Volvo AC buses running every hour. Comfortable seating, onboard entertainment. Duration: 3.5 hours.", 450m, "Bangalore to Mysore" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Premium express train with meals included. Comfortable AC chairs. Duration: 4.5 hours.", 750m, "Delhi to Jaipur (Shatabdi Express)", "Train" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Ferry service from Gateway of India. Scenic boat ride. Duration: 1 hour one way.", 200m, "Mumbai to Elephanta Caves", "Ferry" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Price", "Route" },
                values: new object[] { "Regular bus service along East Coast Road. Semi-sleeper and seater options. Duration: 3 hours.", 350m, "Chennai to Pondicherry" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Daily flights connecting South and East India. Duration: 2 hours. Multiple time slots.", 5200m, "Chennai to Kolkata", "Flight" });

            migrationBuilder.UpdateData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Price", "Route", "TransportType" },
                values: new object[] { "Kerala coastal train with beautiful Arabian Sea views. Duration: 4 hours.", 280m, "Kochi to Trivandrum", "Train" });
        }
    }
}
