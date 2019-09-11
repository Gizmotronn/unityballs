Asteroid Dodger is a game created in the C# programming language in the Unity editor. the object of the game is to get through different levels without being hit by an asteroid. The game is being developed by Orgzy Design & ACORD Robotics for the public. The game will be available for Windows & MacOS devices.

Following Specs recommended:
* Windows 7 or 10, or MacOS El Capitan or higher (No Linux, sorry - install a virtual box or dual boot)
* Keyboard and mouse - preferably with w,a,s,d keys working
* 4 gb of RAM or more - so no Windows XP devices

These features are required to make sure the game runs as smooth as possible.


# Levels
* Level 1 - Artifacts - collect at least 5 artifacts while avoid being hit by any asteroids
* Level 2 - Go Home - Fly across the stars back to your base, avoiding black holes and more asteroids
* Level 3 - Repair Ship - unpack red pickups that have ship parts, and drag them to the correct locations on your ship
* Level 4 - 

More levels coming soon!


# unityballs
My repo for the Unity "Roll-A-Ball" project. 

# What's been done
* Scoring system
* Objects to pick up, or avoid
* Player object
* Most of the scripting for Phase 1 (RollABall) w/ comments
* Spaceship sprite & backgrounds
* Asteroid and pickup sprites

# social
I'd recommend following ACORD on Instagram - http://instagram.com/acordrobotics to check out what we're doing

# School Project
## Part 1
### State the problem
What I want to learn: I want to learn how to create a game for both computers and mobile devices. I want to learn how to code in languages such as C# and C++.

What I want to learn: I want to learn how to create a game for both computers and mobile devices. I want to learn how to code in languages such as C# and C++. I've played games for ages, but mostly science fiction games. I've looked for true space colonization games for years, but until recently I never found any good ones. So, I thought that I should make my own game, and that's what I want to learn. 

Skills I will need: I will need to know how to navigate the Unity interface and I will need to know the C# language. I've only ever created websites before, as I have trouble with understanding the languages used for games such as C# and JavaScript. Last year in Computer Science I created a text-based role-playing game using Python, and Python is a scripting language that I understand well as it is quite logical, and there are only 33 keywords in Python 3 so it is quite easy to understand. I considered creating a game in Python, but as I don't know how to create objects and textures for Python games, the best thing I could have done was a text-based-game, which I don't think is a good representation of my abilities. I used Unity briefly last year in Computer Science as well, and because of my search to find good space games (especially for mobile) and my hopes of learning code, I decided to learn how to use Unity & C#.

The app will be a game that will be available for mobile devices and computers. I intend on making it a game that will primarily entertain younger gamers, as the game will not be on the same level as games that experienced gamers will know. This means that they probably would not get enjoyment out of it, however anyone can play it and there is no real target audience. The needs of the user will be a computer, mouse and keyboard, or a mobile device and their hands, as well as the instructions for the game. The licensing will be open-source, so that everyone can improve the game if they want to and this means that I don't have to look over every proposed change. 

### Tracetable
Line 1	Score <-- 0
Line 2	Repeat
Line 3	Input(movement)
Line 4	     If gameObject collides with pickUp
Line 5	     Score <-- score + 1
Line 6	Until(score == 5)
Line 7	Output("Load Scene 2" after 5 second delay)
	



Line	Score	gameObject collide pickUp	Score = 5	Output
1	 0	 		 
4	 	FALSE	 	 
6	 	 	FALSE	 
5	 0		 	 
4	 	TRUE		 
5	 1	 	 	 
6	 	 	FALSE	 
4		 TRUE	 	 
5	 2		 	 
6	 	 	 FALSE	 
4	 	 TRUE		 
5	3	 	 	 
7	 		 FALSE	 
8	 	 TRUE	 	 
4	 4			 
7	 		 FALSE	 
8	 	TRUE 	 	 
4	 5	 		 
5		 	 TRUE	 
7	 	 	 	Load Level 2


* Type of app - Computer Game
* Target audience - arcade game fans
* Needs of the user - a computer (running Windows or MacOS) with at least 1mb of storage to run the game (possibly mobile). Monitor, keyboard with w,a,s,d keys working

#### Similar Games/Apps
##### Subway Surfers
Subway Surfers is a popular mobile game developed by Kiloo for iOS and Android. The game involves dodging obstacles (trains, barriers) and collecting coins and tools such as magnets and jetpacks, while running away from an angry train condcutor. Subway surfers has an HUD (Heads-up display) located at the top of the screen, which shows your score, number of coins collected, and the amount of durability the tool has. It is a 3D game.

**Subway Surfers vs Asteroid Dodgers**
* HUD - located at top in both games

One of the most popular tutorials on Unity is the Roll-A-Ball tutorial, and this is the tutorial that I followed to learn how to use the Unity interface and get the hang of C#. Roll-A-Ball is a small game that involves a 3D ball (game object) that the player controls that attempts to pick up objects (that are named "pickups") on the play field. My game (Asteroid Dodgers) is quite like Roll-A-Ball, however there are things to avoid (namely asteroids) as well as things to pick up, and in the future levels there will be more of an adventure aspect to the game. Roll A Ball is a game that is not very aesthetically pleasing, however it doesn't need to be as the purpose of it is to show the user how to create games in Unity and is not going to be published on Steam or the Google Play Store.

Subway surfers is another game that is similar to my game. Like Asteroid Dodgers, it has things to avoid (trains, barriers and the policeman that is chasing you) as well as things to pick up (coins and powerups). Subway surfers has very cartoon-style graphics, which works as the average demographic for Subway Surfers is the pre-teen range. Subway surfers has an inventory system (for example, the coins that you have picked up) that is linked to your account, as well as a social network aspect that allows you to connect with your friends and try and beat their scores. The game has a scoring total that is linked to how far you have run, so there is a feature that tracks how far the user has run.

Doodle Jump is a popular "arcade-style" game that has been around for around about 10 years. In Doodle Jump, you play as a character that is "drawn" onto a piece of paper. There are obstacles that are drawn onto the paper that you need to avoid, and in some levels (for example the pirate level) there are coins and other objects to collect. It is similar to Subway surfers in that it has an inventory system and will go on forever until the player dies (by running into an obstacle, for example). Both Subway Surfers and Doodle Jump are procedurally generated, which means that unlike my game (Asteroid Dodgers), there is no set map for each level. Instead, each time the game is loaded it puts different platforms (to jump on), collectables and obstacles in random positions according to rules that are set in the code. For example, in Doodle Jump there could be a rule saying that there can't be 2 monsters (obstacles) within 3 meters of each other. This means that when the map in a level is generated, each object is placed randomly but will make sure that it is possible for the user to continue playing without "dying". 


Skills I will need: I will need to know how to navigate the Unity interface and I will need to know the C# language. 

### What I want to learn
What I want to learn
I want to learn how to program a simple game in Unity using the C# scripting language. In this game I want to learn how to have the user control a game object, with an inventory system and things to avoid and collect.

Understanding skills
To complete this game, I am going to need to learn basic C# scripting, which will allow the object to move and collide with other objects. I am also going to need to learn how to navigate the Unity Game Engine interface, which is something that I have a little knowledge of (as I used Unity for a few weeks last year).

Subskills
As I am going to be coding in C#, I will be needing to add comments in my code to describe what different parts of my code does. To do this, I am going to need to learn what every function I use does (Unity's website has a section that shows each function in C#). I will also need to learn when and where to use comments so that I don't overdo it, and make my code look clean and easily readable.

I will need to learn how to add "skins", or textures to my game objects. I can do this using the Unity interface, but I will need to either create them or download them from the Unity assets store.

## Remove barriers - work efficiently
Location	Equipment	Conditions
Home	Table	Free of everything
Library	Library Desk + Charging port	Cleared
Gardham	Notebook, Computer	
All Locations	Computer (Lenovo Yoga 910)	Microsoft Visual Studio Code
		Unity
		Tutorial/Unity cheatsheet
		Everything else closed
All Locations	Headphones/Earphones	Connected
		Ambient music or heavy metal
Home (Using Desktop)	Mouse	Connected, on mousepad
All Locations	Phone	Silent, charging (if at home) or in pocket (at school)


### Project Timeline
July 7: I started the Roll-A-Ball Tutorial on Unity Tutorials
July 8: I added "pickups" to the game - objects for the player to pick up
July 9: I added a move function to the game
July 10: I added scoring to the game
July 13: I finished the Roll-A-Ball tutorial
July 14: I started to deviate from the standard tutorial.  I added "asteroids", which are objects that the player needs to avoid
July 17: I added a script to the asteroids so that they will remove a point from the player's score
July 18: I downloaded a sprite from the Unity Asset store
July 19: I resized the playboard, the pick up objects and the asteroids because the spaceship sprite is much bigger than the player
July 23: I added a new move function to the spaceship, which previously could not move. I also added a script so that the scoring would work for the spaceship, which is a separate gameObject to the player (which is disabled).
July 26: Sprites added for background, surface and walls

### Type of software license
Public domain - Asteroid Dodgers will be open-source, which means that it will be free and anyone can access and edit the code, like wordpress.org. I want people to be able to add to my game.

### Tracetables

# Sprites
* [Astronaut](https://assetstore.unity.com/packages/3d/characters/humanoids/stylized-astronaut-114298)

## Space station
* [1](https://assetstore.unity.com/packages/3d/environments/sci-fi/space-station-31047)

## Planets
* [1](https://assetstore.unity.com/packages/3d/environments/sci-fi/planets-26903)
* [2](https://assetstore.unity.com/packages/3d/environments/sci-fi/planets-60740)
* [3](https://assetstore.unity.com/packages/3d/environments/sci-fi/planet-earth-free-23399)

## Star Wars
https://clara.io/library?query=starwars&gameCheck=true

## Other sprite resources
* https://www.beffio.com/
* https://nasa3d.arc.nasa.gov/
