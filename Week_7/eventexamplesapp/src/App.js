import React from 'react';
import Counter from './components/Counter';
import Welcome from './components/Welcome';
import SyntheticEvent from './components/SyntheticEvent';
import CurrencyConvertor from './components/CurrencyConvertor';

function App() {
  return (
    <div className="App">
      <h1>React Event Handling Example</h1>
      <Counter />
      <Welcome message="Welcome to React!" />
      <SyntheticEvent />
      <CurrencyConvertor />
    </div>
  );
}

export default App;
