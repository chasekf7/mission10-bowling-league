# Quick Start Guide

This guide will help you get the Bowling League application up and running quickly.

## Running the Application

You'll need to run both the backend API and the frontend React app simultaneously.

### Step 1: Start the ASP.NET Core API

Open a terminal in Rider (⌥F12) or use a separate terminal window:

```bash
cd /Users/chasefisher/413/assignment10/BowlingLeagueAPI
dotnet run --launch-profile http
```

The API will start on `http://localhost:5000`. You should see output like:
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
```

**Rider Tip**: You can also run this directly in Rider by:
1. Right-clicking on the BowlingLeagueAPI project
2. Select "Run 'BowlingLeagueAPI'" (⌃R)
3. Or use the Run Configuration dropdown and click the play button

### Step 2: Start the React Frontend

Open a new terminal tab/window (⌘T in Terminal):

```bash
cd /Users/chasefisher/413/assignment10/bowling-league-frontend
npm run dev
```

The React app will start on `http://localhost:5173`. You should see:
```
  VITE v5.x.x  ready in xxx ms

  ➜  Local:   http://localhost:5173/
```

### Step 3: Open in Browser

Open your web browser and navigate to:
```
http://localhost:5173
```

You should see the Bowling League Bowlers Directory with a table showing bowlers from the Marlins and Sharks teams!

## Troubleshooting

### API Won't Start
- Make sure port 5000 is not already in use
- Run `dotnet clean` and `dotnet build` to rebuild the project
- Check that all NuGet packages are restored: `dotnet restore`

### React App Won't Start
- Make sure Node modules are installed: `npm install`
- Check that port 5173 is available
- Clear cache: `rm -rf node_modules package-lock.json && npm install`

### No Data Showing in Browser
- Check browser console (⌥⌘I in Safari, ⌥⌘J in Chrome)
- Verify API is running on port 5000
- Check for CORS errors in the console
- Make sure the database was created (check for BowlingLeague.db in the API folder)

### Database Issues
If the database isn't created:
```bash
cd /Users/chasefisher/413/assignment10/BowlingLeagueAPI
rm -f BowlingLeague.db  # Remove old database if exists
dotnet run  # This will recreate the database with seed data
```

## Testing the API Directly

You can test the API endpoint directly using curl:

```bash
curl http://localhost:5000/api/bowlers
```

Or open in browser:
```
http://localhost:5000/api/bowlers
```

Or use Swagger UI (when API is running):
```
http://localhost:5000/swagger
```

## Stopping the Application

### Stop the API
In the terminal running the API, press: `Ctrl+C`

In Rider, click the red stop button or press: `⌘F2`

### Stop React
In the terminal running React, press: `Ctrl+C`

## Useful Rider Shortcuts (macOS)

- **Run Project**: ⌃R
- **Debug Project**: ⌃D
- **Stop Running**: ⌘F2
- **Build**: ⌘F9
- **Terminal**: ⌥F12
- **Find in Files**: ⌘⇧F
- **Go to File**: ⌘⇧O
- **Refactor This**: ⌃T

## Project Structure

```
assignment10/
├── BowlingLeagueAPI/              # Backend API
│   ├── Controllers/
│   │   └── BowlersController.cs   # API endpoint
│   ├── Data/
│   │   └── BowlingLeagueContext.cs # Database context
│   ├── Models/                    # Data models
│   └── Program.cs                 # API configuration
│
└── bowling-league-frontend/       # Frontend React App
    └── src/
        ├── components/
        │   ├── Header.jsx         # Page header
        │   └── BowlerTable.jsx    # Bowler data table
        └── App.jsx                # Main app component
```

## GitHub Repository

The code is available at:
**https://github.com/chasekf7/mission10-bowling-league**

## What to Submit

Submit the following link in Learning Suite:
```
https://github.com/chasekf7/mission10-bowling-league
```

Make sure the repository is **PUBLIC** so it can be accessed for grading.

## Need Help?

1. Check the README.md for detailed documentation
2. Review the code comments in each file
3. Check API endpoint at http://localhost:5000/api/bowlers
4. Use browser DevTools console to debug frontend issues
5. Check Rider's Event Log for backend errors
