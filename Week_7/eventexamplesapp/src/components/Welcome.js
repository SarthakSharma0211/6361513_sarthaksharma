import React from 'react';

const Welcome = ({ message }) => {
  const sayWelcome = (msg) => {
    alert(msg);
  };

  return (
    <div>
      <button onClick={() => sayWelcome(message)}>Say Welcome</button>
    </div>
  );
};

export default Welcome;
