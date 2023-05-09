# MovieSystem-MVC-API
This is a movie api written in ASP.NET core for storing people, movies, genres and relationships like LikedGenre(which would be more like PersonGenre) and PersonMovie. It connects to a local database (MicrosoftSQLserver) and with help from Entity Framework it creates all the tables necessary for storing all data. It is built using the MVC style architecture and repository pattern (semi, some controllers do not use repository pattern).

NOTE: I made good use of Swagger, which comes by default on ASP.NET core projects. I have not removed it, it is a great tool for better visual representation of the api and all the calls. You may also note that there are even more calls then the ones i'm listing here, such as POST, PUT and DELETE.

This was made as a school project.

# Special thanks
I want to thank Chas Academy and our mentor Juiceghost for all the help and guidance.<br>
Special Thanks to TMDB (https://www.themoviedb.org/) for letting me use their API and providing me with an API key.<br>
Special thanks to Patrick God for providing such exelent tutorials on Youtube.

Awesome tutorials by Patrick God (API MVC architecture):<br>
https://www.youtube.com/watch?v=Fbf_ua2t6v4 <br>
https://www.youtube.com/watch?v=FHx6AGVF_IE&t=2022s

# Goals
The following goals are what i have tried to achive:

Store people with basic info. <br>
Store unlimited amount of genres, each genre must have a name and description. <br>
Every person should be able to be interested in a genre. <br>
It should be possible to store an unlimited amount of links to movies that are connected to a genre and a specific person. <br>
Optionally use of repository pattern.

### Create a REST-API

The api should be able to make the following calls:

Get all people in the system. <br>
Get all genres that are connected to a specific person. <br>
Get all movies that are connected to a specifik person. <br>
Post and get rating for a movie and specifik person. <br>
Connect person to new genre. <br>
Add new links for specifik person and specifik genre. <br>
Get movie suggestions from external API (like TMDB) based on genre.

# Functions/API-Calls

The following calls are what my API can do.

For getting all people: GET - [your local server and port number here]/api/person

For getting all genres: GET - [your local server and port number here]/api/genre

For getting all movies connected to one specific person: GET - [your local server and port number here]/api/PersonMovie/[PersonId]

For adding and getting rating on a movie with specific person - POST -  [your local server and port number here]/api/PersonMovie

For connection a person to a genre: POST - [your local server and port number here]/api/LikedGenre

Adding links for a specific person and genre: POST -  [your local server and port number here]/api/PersonMovie

NOTE: The /api/PersonMovie can be used for multiple purposes.

Get movie suggestions from TMDB-API: GET - [your local server and port number here]/api/TMDBSuggestionByGenreId/[Id]

NOTE: My api does not have the same Genre Id's as TMDBs. So if you want to use that last one, i suggest you use this api call to get TMDB genre id's: GET - [your local server and port number here]/api/TMDBGetAllGenresId
