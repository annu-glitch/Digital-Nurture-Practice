import React from "react";

const ListofPlayers = () => {
    const players = [
            { name: "Virat Kohli", score: 85 },
            { name: "Rohit Sharma", score: 60 },
            { name: "Shubman Gill", score: 90 },
            { name: "KL Rahul", score: 45 },
            { name: "Shreyas Iyer", score: 96 },
            { name: "Ravindra Jadeja", score: 50 },
            { name: "Jasprit Bumrah", score: 78 },
            { name: "Suryakumar Yadav", score: 68 },
            { name: "Rishabh Pant", score: 88 },
            { name: "Axar Patel", score: 39 },
            { name: "Mohammed Shami", score: 92 },
    ];

    const lowScoringPlayers = players.filter((player) => player.score < 70);

    return (
        <div>
            <h2>All players with scores</h2>
            <ul>
                {players.map((player, index) => (
                    <li key={index}>
                        {player.name} - {player.score}
                    </li>
                ))}
            </ul>

            <h2>Players with score below 70</h2>
            <ul>
                {lowScoringPlayers.map((player, index) => (
                    <li key={index}>
                        {player.name} - {player.score}
                    </li>
                ))}
            </ul>
        </div>
    );
};


export default ListofPlayers;
