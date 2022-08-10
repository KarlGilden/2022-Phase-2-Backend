# 2022-Phase-2-Backend


# Prerequisites:

1. Have SQL Server installed on computer

# Set up instructions:

1. Clone the repository.
2. In console, type "dotnet ef database update.
3. In console, type "dotnet run --environment Development.
4. In brower, go to "https://localhost:7251/swagger/index.html" in order to see API documentation.

# Intended use for the API using Swagger

1. Execute AddTeam. This will create an empty team of pokemon in the database with an id
2. Execute AddPokemonToTeam. Enter the id from your newly created team as teamId, Enter a valid pokemon name as pokemonName.
   Repeat this 6 times as to make a full team
3. Execute GetSummary to get a summary of the team's stats.
