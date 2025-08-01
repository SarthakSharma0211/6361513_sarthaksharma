import React from 'react';
import './App.css';

function App() {
  const offices = [
    { name: "SpaceX Tower", rent: 55000, address: "Bangalore" },
    { name: "Tech Park One", rent: 75000, address: "Hyderabad" },
    { name: "Innovation Hub", rent: 45000, address: "Mumbai" },
  ];

  return (
    <div className="App">
      <h1>Office Space Rental</h1>
      <img src="https://via.placeholder.com/400x200" alt="Office Space" />

      {offices.map((office, index) => (
        <div key={index} style={{ margin: "20px", padding: "10px", border: "1px solid gray" }}>
          <h2>{office.name}</h2>
          <p><strong>Address:</strong> {office.address}</p>
          <p>
            <strong>Rent:</strong> 
            <span style={{ color: office.rent < 60000 ? 'red' : 'green', fontWeight: 'bold' }}>
              ₹{office.rent}
            </span>
          </p>
        </div>
      ))}
    </div>
  );
}

export default App;
