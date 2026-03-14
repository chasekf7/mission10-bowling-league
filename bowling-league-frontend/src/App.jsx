import { useState, useEffect } from 'react';
import Header from './components/Header';
import BowlerTable from './components/BowlerTable';
import './App.css';

function App() {
  const [bowlers, setBowlers] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    // Fetch bowler data from the ASP.NET API
    fetch('http://localhost:5000/api/bowlers')
      .then(response => {
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.json();
      })
      .then(data => {
        setBowlers(data);
        setLoading(false);
      })
      .catch(err => {
        console.error('Error fetching bowlers:', err);
        setError(err.message);
        setLoading(false);
      });
  }, []);

  return (
    <div className="app">
      <Header />
      <BowlerTable bowlers={bowlers} loading={loading} error={error} />
    </div>
  );
}

export default App;
