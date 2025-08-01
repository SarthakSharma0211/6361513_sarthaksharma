import React, { useState } from 'react';

const CurrencyConvertor = () => {
  const [rupees, setRupees] = useState("");
  const [euro, setEuro] = useState("");

  const handleSubmit = () => {
    const euroValue = parseFloat(rupees) / 90; // Approximate
    setEuro(euroValue.toFixed(2));
  };

  return (
    <div>
      <input
        type="text"
        placeholder="Enter amount in INR"
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
      />
      <button onClick={handleSubmit}>Convert</button>
      <p>Euro: €{euro}</p>
    </div>
  );
};

export default CurrencyConvertor;
