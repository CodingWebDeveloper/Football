using Football_HW.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Football_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoalKeeper goalKeeper = new GoalKeeper("Miro", 19, 0, 9);
            Striker striker1 = new Striker("Halland", 19, 0, 9);
            Striker striker2 = new Striker("Ronaldo", 25, 0, 9);

            Defender defender1 = new Defender("Lakaka", 30, 0, 9);
            Defender defender2 = new Defender("Van Djk", 25, 0, 9);
            Defender defender3 = new Defender("Maguire", 20, 0, 9);
            Defender defender4 = new Defender("Miro", 19, 0, 9);
            Midfield midfielder1 = new Midfield("Miro", 21, 0, 9);
            Midfield midfielder2 = new Midfield("Miro", 20, 0, 9);
            Midfield midfielder3 = new Midfield("Miro", 19, 0, 9);
            Midfield midfielder4 = new Midfield("Miro", 19, 0, 9);

            Coach coach = new Coach("Jose Morinho", 55);
            List<FootballPlayer> players = new List<FootballPlayer>();
            players.Add(goalKeeper);
            players.Add(striker1);
            players.Add(striker2);
            players.Add(defender1);
            players.Add(defender2);
            players.Add(defender3);
            players.Add(defender4);
            players.Add(midfielder1);
            players.Add(midfielder2);
            players.Add(midfielder3);
            players.Add(midfielder4);


            GoalKeeper opponentGoalKeeper = new GoalKeeper("De Gea", 19, 0, 9);
            Striker opponentStriker1 = new Striker("Messi", 19, 0, 9);
            Striker opponentStriker2 = new Striker("Sterling", 25, 0, 9);

            Defender opponentDefender1 = new Defender("Lakaka1", 30, 0, 9);
            Defender opponentDefender2 = new Defender("Van Djk1", 25, 0, 9);
            Defender opponentDefender3 = new Defender("Maguire1", 20, 0, 9);
            Defender opponentDefender4 = new Defender("Miro1", 19, 0, 9);
            Midfield opponentMidfielder1 = new Midfield("Miro2", 21, 0, 9);
            Midfield opponentMidfielder2 = new Midfield("Miro3", 20, 0, 9);
            Midfield opponentMidfielder3 = new Midfield("Miro4", 19, 0, 9);
            Midfield opponentMidfielder4 = new Midfield("Miro5", 19, 0, 9);

            Coach opponentCoach = new Coach("Jose Morinho", 55);
            List<FootballPlayer> opponentPlayers = new List<FootballPlayer>();
            opponentPlayers.Add(opponentGoalKeeper);
            opponentPlayers.Add(opponentStriker1);
            opponentPlayers.Add(opponentStriker2);
            opponentPlayers.Add(opponentDefender1);
            opponentPlayers.Add(opponentDefender2);
            opponentPlayers.Add(opponentDefender3);
            opponentPlayers.Add(opponentDefender4);
            opponentPlayers.Add(opponentMidfielder1);
            opponentPlayers.Add(opponentMidfielder2);
            opponentPlayers.Add(opponentMidfielder3);
            opponentPlayers.Add(opponentMidfielder4);

            Team team1 = new Team(coach, players);
            Team team2 = new Team(opponentCoach, opponentPlayers);

            List<FootballPlayer> team1Players = team1.Players.ToList();
            List<FootballPlayer> team2Players = team2.Players.ToList();

            GameTeam gameTeam1 = new GameTeam(team1, team1Players);
            GameTeam gameTeam2 = new GameTeam(team2, team2Players);

            Referee referee = new Referee("Soman", 40);

            Referee asistentReferee1 = new Referee("John", 32);
            Referee assistentReferee2 = new Referee("Pesho", 33);

            List<Goal> goals = new List<Goal>();
            goals.Add(new Goal(56, striker1));
            goals.Add(new Goal(86, striker1));

            Game game = new Game(gameTeam1, gameTeam2, referee, asistentReferee1, assistentReferee2, goals);

            Console.WriteLine(game.GameResult());
            Console.WriteLine(game.Winner());
        }
    }
}
