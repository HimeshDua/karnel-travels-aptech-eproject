using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace karnel_travels_mvc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Availability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resorts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Availability = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resorts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Availability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TouristSpots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristSpots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Route = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { 1, 25, "Luxury 5-star hotel with sea view rooms, rooftop restaurant, and spa facilities.", "Mumbai", "Grand Plaza Hotel", 5500m, "5-Star" },
                    { 2, 18, "Premium hotel near India Gate with conference halls and fine dining.", "Delhi", "Taj Palace", 6200m, "5-Star" },
                    { 3, 32, "Comfortable beachfront hotel with modern amenities and seafood restaurant.", "Chennai", "Beach View Inn", 3200m, "4-Star" },
                    { 4, 15, "Converted palace hotel with traditional Rajasthani decor and cultural performances.", "Jaipur", "Heritage Hotel", 4800m, "4-Star" },
                    { 5, 28, "Resort-style hotel with pool, beach access, and water sports facilities.", "Goa", "Coastal Retreat", 4200m, "4-Star" },
                    { 6, 42, "Budget-friendly hotel in city center with basic amenities and free WiFi.", "Bangalore", "City Center Lodge", 1800m, "Budget" },
                    { 7, 20, "Hill station hotel with panoramic mountain views and cozy fireplace rooms.", "Shimla", "Mountain View Hotel", 3500m, "3-Star" }
                });

            migrationBuilder.InsertData(
                table: "Resorts",
                columns: new[] { "Id", "Availability", "Capacity", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { 1, 15, 120, "Luxury beachfront resort with private villas, infinity pool, spa, and water sports.", "Goa", "Ocean Paradise Resort", 8500m, "Luxury" },
                    { 2, 22, 80, "Eco-resort on backwaters with houseboat stays, Ayurvedic spa, and yoga sessions.", "Alleppey", "Backwater Bliss Resort", 6500m, "Premium" },
                    { 3, 18, 60, "Mountain resort with cottages, bonfire evenings, trekking, and tea plantation tours.", "Ooty", "Hill Station Retreat", 5200m, "Premium" },
                    { 4, 25, 100, "Desert camp experience with camel safari, cultural programs, and traditional Rajasthani hospitality.", "Jaisalmer", "Desert Safari Resort", 4800m, "Standard" },
                    { 5, 12, 50, "Nature resort near national park with jungle safaris, bird watching, and campfires.", "Jim Corbett", "Wildlife Adventure Resort", 7200m, "Premium" },
                    { 6, 8, 40, "Tropical island resort with scuba diving, snorkeling, beach activities, and coral reef tours.", "Andaman", "Island Paradise Resort", 9500m, "Luxury" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { 1, 50, "Authentic Indian cuisine with North and South Indian specialties, tandoor dishes.", "Mumbai", "Spice Garden", 800m, "Premium" },
                    { 2, 40, "Fresh seafood restaurant specializing in coastal delicacies and traditional recipes.", "Chennai", "Coastal Kitchen", 650m, "Premium" },
                    { 3, 35, "Rajasthani royal cuisine in heritage ambiance with live folk music.", "Jaipur", "Royal Dine", 950m, "Premium" },
                    { 4, 60, "Beachside restaurant serving Goan fish curry, vindaloo, and Portuguese pastries.", "Goa", "Goan Shack", 550m, "Standard" },
                    { 5, 100, "Popular street food court offering chaat, momos, kebabs, and regional snacks.", "Delhi", "Street Food Hub", 250m, "Budget" },
                    { 6, 45, "Traditional Kerala cuisine with appam, stew, fish moilee, and sadya meals.", "Kochi", "Kerala Kitchen", 450m, "Standard" },
                    { 7, 38, "Modern fusion restaurant blending Indian and continental flavors.", "Bangalore", "Fusion Bistro", 750m, "Premium" }
                });

            migrationBuilder.InsertData(
                table: "TouristSpots",
                columns: new[] { "Id", "Description", "IsAvailable", "Location", "Name", "Quality" },
                values: new object[,]
                {
                    { 1, "One of the longest urban beaches in the world, perfect for evening walks and local street food.", true, "Chennai", "Marina Beach", "Excellent" },
                    { 2, "Iconic white marble mausoleum, one of the Seven Wonders of the World.", true, "Agra", "Taj Mahal", "Excellent" },
                    { 3, "Historic arch monument overlooking the Arabian Sea, built during British rule.", true, "Mumbai", "Gateway of India", "Excellent" },
                    { 4, "Palace of Winds, five-story structure with unique honeycomb design and 953 small windows.", true, "Jaipur", "Hawa Mahal", "Good" },
                    { 5, "Historic Hindu temple dedicated to Meenakshi, featuring stunning Dravidian architecture.", true, "Madurai", "Meenakshi Temple", "Excellent" },
                    { 6, "Beautiful tropical beaches with water sports, nightlife, and Portuguese heritage.", true, "Goa", "Goa Beaches", "Good" },
                    { 7, "Network of lagoons and lakes with houseboat cruises through scenic waterways.", true, "Alleppey", "Kerala Backwaters", "Excellent" },
                    { 8, "Massive red sandstone fort complex built by Mughal emperor Shah Jahan.", false, "Delhi", "Red Fort", "Good" }
                });

            migrationBuilder.InsertData(
                table: "TravelInfos",
                columns: new[] { "Id", "Availability", "Description", "Price", "Route", "TransportType" },
                values: new object[,]
                {
                    { 1, true, "Scenic train journey through Western Ghats. Daily service, AC and sleeper coaches available. Duration: 12 hours.", 850m, "Mumbai to Goa (Konkan Railway)", "Train" },
                    { 2, true, "Multiple daily flights by major carriers. Flight duration: 2.5 hours. Economy and business class available.", 4500m, "Delhi to Mumbai", "Flight" },
                    { 3, true, "Luxury Volvo AC buses running every hour. Comfortable seating, onboard entertainment. Duration: 3.5 hours.", 450m, "Bangalore to Mysore", "Bus" },
                    { 4, true, "Premium express train with meals included. Comfortable AC chairs. Duration: 4.5 hours.", 750m, "Delhi to Jaipur (Shatabdi Express)", "Train" },
                    { 5, true, "Ferry service from Gateway of India. Scenic boat ride. Duration: 1 hour one way.", 200m, "Mumbai to Elephanta Caves", "Ferry" },
                    { 6, true, "Regular bus service along East Coast Road. Semi-sleeper and seater options. Duration: 3 hours.", 350m, "Chennai to Pondicherry", "Bus" },
                    { 7, true, "Daily flights connecting South and East India. Duration: 2 hours. Multiple time slots.", 5200m, "Chennai to Kolkata", "Flight" },
                    { 8, false, "Kerala coastal train with beautiful Arabian Sea views. Duration: 4 hours.", 280m, "Kochi to Trivandrum", "Train" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Resorts");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "TouristSpots");

            migrationBuilder.DropTable(
                name: "TravelInfos");
        }
    }
}
