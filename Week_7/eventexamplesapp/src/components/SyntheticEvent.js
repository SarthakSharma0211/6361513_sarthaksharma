import React from 'react';

const SyntheticEvent = () => {
  const handleClick = (e) => {
    e.preventDefault();
    alert("I was clicked");
  };

  return (
    <div>
      <button onClick={handleClick}>OnPress</button>
    </div>
  );
};

export default SyntheticEvent;
