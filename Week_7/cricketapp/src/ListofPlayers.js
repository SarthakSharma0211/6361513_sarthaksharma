import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Rohit', score: 90 },
    { name: 'Virat', score: 85 },
    { name: 'Rahul', score: 60 },
    { name: 'Pant', score: 50 },
    { name: 'Iyer', score: 77 },
    { name: 'Jadeja', score: 88 },
    { name: 'Ashwin', score: 45 },
    { name: 'Bumrah', score: 67 },
    { name: 'Shami', score: 72 },
    { name: 'Kuldeep', score: 40 },
    { name: 'Siraj', score: 91 },
  ];

  const filteredPlayers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>

      <h2>Players with Score below 70</h2>
      <ul>
        {filteredPlayers.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
