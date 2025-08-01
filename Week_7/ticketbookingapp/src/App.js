import React, { useState } from 'react';
import GuestPage from './GuestPage';
import UserPage from './UserPage';

function App() {
  // Step 4: State to control login status
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  // Step 4: Event handlers to toggle state
  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  // Step 4: Conditional Rendering using ternary operator
  return (
    <div className="App">
      <h1>✈️ Ticket Booking App</h1>

      {isLoggedIn ? (
        <>
          <button onClick={handleLogout}>Logout</button>
          <UserPage />
        </>
      ) : (
        <>
          <button onClick={handleLogin}>Login</button>
          <GuestPage />
        </>
      )}
    </div>
  );
}

export default App;
