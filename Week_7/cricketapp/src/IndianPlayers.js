import React from 'react';

const IndianPlayers = () => {
  const T20 = ['Rohit', 'Virat', 'Surya', 'Hardik', 'Kuldeep'];
  const Ranji = ['Jaiswal', 'Sarfaraz', 'Pujara', 'Rahane', 'Saha'];

  const merged = [...T20, ...Ranji];

  const [first, second, third, fourth, fifth, ...rest] = merged;

  const oddTeam = merged.filter((_, idx) => idx % 2 === 0);
  const evenTeam = merged.filter((_, idx) => idx % 2 !== 0);

  return (
    <div>
      <h2>Merged Players</h2>
      <ul>
        {merged.map((player, idx) => (
          <li key={idx}>{player}</li>
        ))}
      </ul>

      <h2>Odd Team Players</h2>
      <ul>
        {oddTeam.map((player, idx) => (
          <li key={idx}>{player}</li>
        ))}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenTeam.map((player, idx) => (
          <li key={idx}>{player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
