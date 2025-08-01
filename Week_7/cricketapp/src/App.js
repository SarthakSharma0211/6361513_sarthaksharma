import React from 'react';
import ListofPlayers from './ListofPlayers';
import IndianPlayers from './IndianPlayers';

function App() {
  const flag = false; // Toggle this to false to see other component

  return (
    <div className="App">
      <h1>Cricket App</h1>
      {flag ? <ListofPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;
