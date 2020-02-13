# TournamentTracker
An application to create, manage and track a single elimination tournament, supporting a variable number of teams.


# Planning Process
## Scenario
Your friends come to you and ask you to create a tournament tracker. They are always playing games and want to determine who is the best. The idea is that you create a bracket tournament system where the computer will tell them who to play in a single-elimination style bracket. At the end, the winner should be identified. Their model is the NVAA Basketball tournament bracket for March Madness.

## Requirements
	1. Tracks games and their outcome (who won).
	2. Multiple competitors play in the tournament.
	3. Creates a tournament plan (who plays in what order).
	4. Schedule games.
	5. A single loss eliminates a player.
	6. The last player standing is the winner.

## Big Picture Design
Structure: Windows Forms Application and Class Library
Data: SQL and/or Text File
Users: One at a time, on one application.

Key Concepts:
	• Emailing from C#
	• SQL
	• Custom Events (Checking Tournament Status, Triggering Emails)
	• Error Handling (User Input)
	• Interfaces (Data Passing, Form to Form)
	• Random Ordering (Games, Byes, etc.)
  • Text Notifications (Additional Feature)
  
# Data Design
## Mapping The Data
Team
	• TeamMembers (List<Person>)
	• TeamName (string)

Person
	• FirstName (string)
	• LastName (string)
	• EmailAddress (string)
	• CellNumber (string)

Tournament
	• TournamentName (string)
	• EntryFee (decimal)
	• EnteredTeams (List<Team>)
	• Prizes (List<Prize>)
	• Rounds (List<List<Matchup>>)

Prize
	• PlaceNumber (int)
	• PlaceName (string)
	• PrizeAmount (decimal)
	• PrizePercentage (double)

Matchup
	• Entries (List<MatchupEntry>)
	• Winner (Team)
	• MatchupRound (int)

MatchupEntry
	• TeamCompeting (Team)
	• Score (double)
  • ParentMatchup (Matchup)
