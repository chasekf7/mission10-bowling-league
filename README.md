# Bowling League Bowlers Directory

A full-stack web application that displays information about bowlers from the Bowling League Database. This project consists of an ASP.NET Core Web API backend and a React frontend.

## Assignment Information
- **Course**: IS 413 - Professor Hilton
- **Mission**: Assignment #10
- **Student**: Chase Fisher

## Features
- Displays bowlers from the Marlins and Sharks teams
- Shows complete bowler information including:
  - Full name (First, Middle Initial, Last)
  - Team name
  - Address
  - City, State, Zip
  - Phone number
- Clean, responsive table interface
- Professional header component

## Technology Stack

### Backend (ASP.NET Core API)
- ASP.NET Core 10.0
- Entity Framework Core 10.0
- SQLite Database
- Swagger/OpenAPI documentation

### Frontend (React)
- React 18
- Vite
- Modern CSS styling
- Fetch API for data retrieval

## Project Structure
```
assignment10/
├── BowlingLeagueAPI/          # ASP.NET Core Web API
│   ├── Controllers/           # API controllers
│   ├── Data/                  # Database context
│   ├── Models/                # Data models and DTOs
│   └── Properties/            # Launch settings
├── bowling-league-frontend/   # React application
│   └── src/
│       ├── components/        # React components
│       │   ├── Header.jsx     # Page header component
│       │   └── BowlerTable.jsx # Bowler data table component
│       └── App.jsx            # Main application component
└── README.md                  # This file
```

## Setup Instructions

### Prerequisites
- .NET 10.0 SDK
- Node.js and npm
- Git

### Backend Setup
1. Navigate to the API directory:
   ```bash
   cd BowlingLeagueAPI
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the API:
   ```bash
   dotnet run
   ```

   The API will start on `http://localhost:5000`

### Frontend Setup
1. Navigate to the frontend directory:
   ```bash
   cd bowling-league-frontend
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

3. Start the development server:
   ```bash
   npm run dev
   ```

   The React app will start on `http://localhost:5173`

## API Endpoints

### GET /api/bowlers
Returns a list of all bowlers from the Marlins and Sharks teams.

**Response Example:**
```json
[
  {
    "bowlerID": 1,
    "bowlerFirstName": "David",
    "bowlerMiddleInit": "M",
    "bowlerLastName": "Fournier",
    "teamName": "Marlins",
    "bowlerAddress": "7822 Winding Way",
    "bowlerCity": "San Diego",
    "bowlerState": "CA",
    "bowlerZip": "92126",
    "bowlerPhoneNumber": "(619) 555-5511"
  }
]
```

## Database Schema

### Teams Table
- TeamID (Primary Key)
- TeamName
- CaptainID

### Bowlers Table
- BowlerID (Primary Key)
- BowlerFirstName
- BowlerMiddleInit
- BowlerLastName
- BowlerAddress
- BowlerCity
- BowlerState
- BowlerZip
- BowlerPhoneNumber
- TeamID (Foreign Key)

## Components Description

### Header Component
A styled header that displays the application title and subtitle, explaining the purpose of the page.

### BowlerTable Component
A data table component that:
- Receives bowler data as props
- Displays loading state while fetching data
- Shows error messages if data fetch fails
- Renders bowler information in a clean, organized table format
- Includes hover effects for better user experience

### App Component
The main application component that:
- Manages application state (bowlers, loading, error)
- Fetches data from the API on component mount
- Composes the Header and BowlerTable components

## Development Notes

### Rider IDE Tips (macOS)
- **Run Configuration**: Use the "http" profile in launchSettings.json
- **Debug**: Set breakpoints by clicking in the gutter (⌘F8)
- **Build**: ⌘F9 or Build > Build Solution
- **Run**: ⌃R or Run > Run 'BowlingLeagueAPI'
- **Stop**: ⌘F2 or Run > Stop

### CORS Configuration
The API is configured to accept requests from:
- http://localhost:5173 (Vite default port)
- http://localhost:3000 (Create React App default port)

## Assignment Requirements Checklist
- ✅ Downloaded Bowling League Database
- ✅ Set up ASP.NET Core Web API
- ✅ Created Entity Framework models
- ✅ Implemented API endpoint for bowlers
- ✅ Created React frontend with Vite
- ✅ Built Header component
- ✅ Built BowlerTable component
- ✅ Integrated components in App
- ✅ Display only Marlins and Sharks teams
- ✅ Show all required bowler information
- ✅ Pushed to public GitHub repository

## Author
Chase Fisher

## License
Educational project for IS 413
