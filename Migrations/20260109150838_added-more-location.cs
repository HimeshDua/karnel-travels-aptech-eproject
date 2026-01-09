using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace karnel_travels_mvc.Migrations
{
    /// <inheritdoc />
    public partial class addedmorelocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { 8, 20, "Luxury hotel in Islamabad with modern amenities.", "Islamabad", "Islamabad Marriott Hotel", 23000m, "5-Star" },
                    { 9, 18, "Luxury hotel on Mall Road with historic charm.", "Lahore", "Avari Towers Lahore", 20000m, "5-Star" },
                    { 10, 15, "5-star hotel serving Islamabad/Rawalpindi area.", "Rawalpindi", "Pearl Continental Rawalpindi", 22000m, "5-Star" },
                    { 11, 18, "Downtown luxury hotel with international brand.", "Karachi", "Karachi Marriott Hotel", 25000m, "5-Star" },
                    { 12, 22, "Modern hotel in Clifton area with upscale dining.", "Karachi", "Hilton Karachi", 18000m, "5-Star" },
                    { 13, 25, "Boutique hotel in Karimabad with mountain views.", "Hunza", "Serena Inn Hunza", 12000m, "3-Star" },
                    { 14, 20, "Popular hotel near Duikar with panoramic Hunza valley views.", "Hunza", "Eagle’s Nest Hotel", 15000m, "4-Star" },
                    { 15, 12, "Heritage hotel in a restored fort near Skardu.", "Skardu", "Serena Shigar Fort", 22000m, "Luxury" },
                    { 16, 10, "5-star hill resort near Madyan with ski facilities.", "Swat", "Pearl Continental Swat (Madyan)", 20000m, "5-Star" },
                    { 17, 30, "Mid-range hotel in Swat Valley with modern amenities.", "Swat", "Swat Continental Hotel", 8000m, "3-Star" },
                    { 18, 14, "Luxury mountain resort at Malam Jabba ski area.", "Swat", "Serena Hotel Malam Jabba", 15000m, "5-Star" }
                });

            migrationBuilder.InsertData(
                table: "Resorts",
                columns: new[] { "Id", "Availability", "Capacity", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { 7, 8, 70, "Luxury mountain resort with ski facilities in Swat.", "Malam Jabba", "Swat Serena Resort", 25000m, "Luxury" },
                    { 8, 10, 60, "High-end hill resort overlooking the Kunhar River.", "Naran", "Pearl Continental Resort Naran", 22000m, "Luxury" },
                    { 9, 20, 50, "Remote resort at the base of Nanga Parbat (Fairy Meadows).", "Nanga Parbat Basecamp", "Fairy Meadows Resort", 8000m, "Standard" },
                    { 10, 15, 40, "Eco-resort surrounded by forests near Gilgit.", "Naltar", "Jungle Resort Naltar", 9000m, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Availability", "Description", "Location", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { 8, 50, "Famous for spicy karahi dishes in Lahore.", "Lahore", "Butt Karahi", 600m, "Standard" },
                    { 9, 30, "Popular restaurant with Lahore Fort views.", "Lahore", "Cooco's Den", 1200m, "Premium" },
                    { 10, 25, "Outdoor Italian restaurant in F-6 area.", "Islamabad", "Tuscany Courtyard", 2000m, "Premium" },
                    { 11, 35, "Coffee shop and bakery known for desserts.", "Islamabad", "Burning Brownie", 800m, "Standard" },
                    { 12, 40, "Upscale Mediterranean restaurant in Clifton.", "Karachi", "Okra", 2500m, "Premium" },
                    { 13, 60, "Well-known BBQ and grill restaurant in Clifton.", "Karachi", "BBQ Tonight", 1700m, "Premium" },
                    { 14, 30, "Contemporary cafe and restaurant in Clifton.", "Karachi", "Xander's", 1800m, "Premium" },
                    { 15, 20, "Popular cafe in Karimabad serving local Hunza dishes.", "Hunza", "Amber Cafe", 800m, "Standard" },
                    { 16, 15, "Alpine-style restaurant at Malam Jabba resort.", "Swat", "Peach Hotel Restaurant", 1000m, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "TouristSpots",
                columns: new[] { "Id", "Description", "IsAvailable", "Location", "Name", "Quality" },
                values: new object[,]
                {
                    { 9, "Historic Mughal fort adjacent to Badshahi Mosque.", true, "Lahore", "Lahore Fort", "Excellent" },
                    { 10, "National monument where Pakistan Resolution was passed.", true, "Lahore", "Minar-e-Pakistan", "Excellent" },
                    { 11, "17th century Mughal mosque famous for its frescoes.", true, "Lahore", "Wazir Khan Mosque", "Excellent" },
                    { 12, "Popular city beach on the Arabian Sea, known for camel rides and food stalls.", true, "Karachi", "Clifton Beach", "Good" },
                    { 13, "Mausoleum of Quaid-e-Azam Muhammad Ali Jinnah, an iconic Karachi landmark.", true, "Karachi", "Mazar-e-Quaid", "Excellent" },
                    { 14, "National monument symbolizing Pakistan’s unity (foothills of Margalla).", true, "Islamabad", "Pakistan Monument", "Excellent" },
                    { 15, "Hilltop park with panoramic views of Islamabad city.", true, "Islamabad", "Daman-e-Koh", "Good" },
                    { 16, "Cultural museum showcasing Pakistan’s diverse traditions.", true, "Islamabad", "Lok Virsa Heritage Museum", "Good" },
                    { 17, "8th-century fort overlooking Karimabad in Hunza Valley.", true, "Gilgit-Baltistan", "Baltit Fort", "Excellent" },
                    { 18, "Distinctive jagged peaks along the Karakoram Highway in Hunza.", true, "Gilgit-Baltistan", "Passu Cones", "Good" },
                    { 19, "Scenic turquoise lake in Hunza (formed by 2010 landslide).", true, "Gilgit-Baltistan", "Attabad Lake", "Good" },
                    { 20, "High-altitude plateau (Land of Giants) near Skardu, famed for wildflowers.", true, "Gilgit-Baltistan", "Deosai National Park", "Excellent" },
                    { 21, "Mountain lake near Skardu supplying fresh water to the valley.", true, "Gilgit-Baltistan", "Satpara Lake", "Good" },
                    { 22, "Mountain resort and ski area in Swat Valley.", true, "Swat", "Malam Jabba", "Good" },
                    { 23, "Alpine lake in the Ushu Valley of Swat (fishing & boating).", true, "Swat", "Mahodand Lake", "Good" },
                    { 24, "Cedar forest in Swat, gateway to Mahodand Lake.", true, "Swat", "Ushu Forest", "Good" },
                    { 25, "Archaeological museum in Saidu Sharif, showcasing Gandharan artifacts.", true, "Swat", "Swat Museum", "Standard" }
                });

            migrationBuilder.InsertData(
                table: "TravelInfos",
                columns: new[] { "Id", "Availability", "Description", "Price", "Route", "TransportType" },
                values: new object[,]
                {
                    { 9, true, "Daily flights (PIA/SereneAir). Duration ~1h45.", 10000m, "Karachi to Lahore", "Flight" },
                    { 10, true, "Express train (Awam/Jaffar Express). Duration ~6h.", 1800m, "Lahore to Peshawar", "Train" },
                    { 11, true, "Daewoo Express bus service. Duration ~2h30m.", 1500m, "Islamabad to Peshawar", "Bus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TouristSpots",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TravelInfos",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
