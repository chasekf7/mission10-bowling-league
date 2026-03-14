import React from 'react';
import './BowlerTable.css';

function BowlerTable({ bowlers, loading, error }) {
  if (loading) {
    return <div className="loading">Loading bowler data...</div>;
  }

  if (error) {
    return <div className="error">Error loading bowlers: {error}</div>;
  }

  if (!bowlers || bowlers.length === 0) {
    return <div className="no-data">No bowler data available.</div>;
  }

  return (
    <div className="table-container">
      <table className="bowler-table">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((bowler) => (
            <tr key={bowler.bowlerID}>
              <td>
                {bowler.bowlerFirstName}{' '}
                {bowler.bowlerMiddleInit ? `${bowler.bowlerMiddleInit}. ` : ''}
                {bowler.bowlerLastName}
              </td>
              <td>{bowler.teamName}</td>
              <td>{bowler.bowlerAddress}</td>
              <td>{bowler.bowlerCity}</td>
              <td>{bowler.bowlerState}</td>
              <td>{bowler.bowlerZip}</td>
              <td>{bowler.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default BowlerTable;
