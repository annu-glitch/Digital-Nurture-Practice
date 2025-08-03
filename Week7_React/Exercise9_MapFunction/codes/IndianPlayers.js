import React from "react";

const IndianPlayers = () => {
  const team = [
    "Virat Kohli",
    "Rohit Sharma",
    "Shubman Gill",
    "KL Rahul",
    "Shreyas Iyer",
    "Ravindra Jadeja",
    "Jasprit Bumrah",
    "Suryakumar Yadav",
    "Rishabh Pant",
    "Axar Patel",
    "Mohammed Shami",
  ];

  const oddPlayers = team.filter((_, index) => index % 2 !== 0);
  const evenPlayers = team.filter((_, index) => index % 2 === 0);

  const T20players = ["Virat", "Rohit", "Hardik"];
  const RanjiTrophy = ["Shaw", "Saha", "Jadeja"];

  const allPlayers = [...T20players, ...RanjiTrophy];

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        {oddPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Merged T20 + Ranji Trophy Players</h2>
      <ul>
        {allPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
