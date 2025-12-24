# Karnel Travel Guide

> A comprehensive ASP.NET Core MVC web application for browsing travel information

## 🌟 Overview

Karnel Travel Guide is an information-rich web application built with ASP.NET Core MVC (.NET 10) that provides tourists with comprehensive details about:
- 🏖️ Tourist destinations and attractions
- 🏨 Hotels and accommodations
- 🍽️ Restaurants and dining
- 🏝️ Resorts and vacation spots
- 🚂 Transportation services (trains, buses, flights, ferries)

**Important**: This is an information display system only. No authentication, booking, or payment features are included (by design).

## 🚀 Quick Start

### Prerequisites
- .NET 10 SDK
- SQL Server LocalDB

### Run the Application

```powershell
# Navigate to project directory
cd "d:\Coding Sessions\Karnel-Chachu\karnel-travels-mvc"

# Apply database migrations (first time only)
dotnet ef database update

# Run the application
dotnet run
```

Open your browser and navigate to: **http://localhost:5200**

## 📋 Features

### Pages Implemented
- ✅ **Home** - Welcome page with website introduction
- ✅ **About Us** - Company overview and services
- ✅ **Search** - Multi-criteria search with filters (location, price, quality, availability)
- ✅ **Information Hub** - Central navigation to 5 categories
- ✅ **Tourist Spots** - List of destinations with details
- ✅ **Travel Info** - Transportation options and routes
- ✅ **Hotels** - Accommodation listings with pricing
- ✅ **Restaurants** - Dining establishments
- ✅ **Resorts** - Vacation resorts with capacity information
- ✅ **Contact Us** - Company contact details and feedback form

### Global Navigation
All pages include a consistent navigation menu with links to:
- Home
- About Us
- Search
- Information
- Contact Us

## 🗄️ Database

The application uses **SQL Server LocalDB** with the following entities:

1. **TouristSpots** - 8 seeded entries (Marina Beach, Taj Mahal, etc.)
2. **Hotels** - 7 seeded entries (luxury to budget)
3. **Restaurants** - 7 seeded entries (various cuisines)
4. **Resorts** - 6 seeded entries (beach, backwater, hill station, etc.)
5. **TravelInfos** - 8 seeded entries (trains, buses, flights, ferries)
6. **Feedbacks** - User submissions from contact form

## 🏗️ Architecture

- **Framework**: ASP.NET Core MVC (.NET 10)
- **ORM**: Entity Framework Core 10.0
- **Database**: SQL Server LocalDB
- **UI**: Razor Views + HTML5 + CSS3
- **Pattern**: MVC (Model-View-Controller)

## 📁 Project Structure

```
karnel-travels-mvc/
├── Controllers/           # 3 MVC controllers
├── Data/                  # DbContext
├── Models/                # 8 entity models
├── Views/                 # 13 Razor views
│   ├── Home/
│   ├── Search/
│   ├── Information/
│   └── Shared/
├── wwwroot/
│   ├── css/              # Site styling
│   └── js/               # Minimal JavaScript
├── Migrations/           # EF Core migrations
└── PROJECT_DOCUMENTATION.md  # Comprehensive docs

```

## 📖 Documentation

See **[PROJECT_DOCUMENTATION.md](PROJECT_DOCUMENTATION.md)** for comprehensive documentation including:
- Project Synopsis
- Problem Definition
- Customer Requirements
- Database ER Diagram
- Algorithms (Search, Feedback Submission)
- GUI Standards
- Interface Design
- Unit Testing Checklist
- Complete Run Instructions

## 🎯 Scope

### ✅ Implemented
- Information display for all travel categories
- Multi-criteria search functionality
- Contact/feedback form with database persistence
- Responsive design for mobile devices
- Clean, minimal UI

### ❌ NOT Implemented (By Design)
- ❌ User authentication or login
- ❌ Booking or reservation system
- ❌ Online payment processing
- ❌ Admin panel or CMS
- ❌ REST APIs
- ❌ JavaScript frameworks (React, Angular, Vue)

## 💻 Technology Stack

| Component | Technology |
|-----------|-----------|
| Framework | ASP.NET Core MVC (.NET 10) |
| Language | C# |
| Database | SQL Server LocalDB |
| ORM | Entity Framework Core 10.0 |
| Views | Razor Pages |
| Styling | CSS3 |
| JavaScript | Vanilla JS (minimal) |

## 🧪 Testing

```powershell
# Build the project
dotnet build

# Run the application
dotnet run

# Access at http://localhost:5200
```

**Manual Testing Checklist**:
- [ ] Navigate through all menu items
- [ ] Test search with different filter combinations
- [ ] Submit feedback through contact form
- [ ] View all 5 information category pages
- [ ] Check responsive design on mobile screen size

## 👨‍💻 Development

**Code Quality**:
- All controllers have comprehensive XML comments
- All models include property documentation
- All views have explanatory comments
- Clean naming conventions throughout
- Proper MVC separation of concerns

**Database Migrations**:
```powershell
# Create new migration
dotnet ef migrations add MigrationName

# Apply migrations
dotnet ef database update

# Remove last migration
dotnet ef migrations remove
```

## 📄 License

This is an academic/demo project for educational purposes.

## 📞 Contact

For questions or feedback about this project, use the **Contact Us** page in the application.

---

**Built with** ❤️ **using ASP.NET Core MVC (.NET 10)**

**Status**: ✅ Production Ready
**Last Updated**: December 23, 2025
