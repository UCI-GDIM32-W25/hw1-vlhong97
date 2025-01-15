[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

How would you describe this game world in objects?
The game consists of four objects: the player, the plants, seeds, and the UI text for plants remaining/planted. 

What attributes and actions do these objects have?
Attributes to the player is its bunny sprite and the number of seeds it has. Its actions are the ability to move up, 
down, left, and right using the W, A, S, D keys. They can also plant seeds using the spacebar. The plant object doesn’t 
have any actions besides existing. An attribute the plant has is its sprite. 

How do these objects act on or affect each other?
The player initiates the action to spawn the plant once pressing the spacebar. The plants do not exist prior to being 
spawned by the player’s spacebar. The player can only plant the number of seeds it's been previously given at the 
beginning of the game. 

--------------------------------------------------------------------------------------------------------------------

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). 
If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe 
HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given 
by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects 
to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
Despite there being four objects in the game, there were only three gameObjects in the Main scene: Player, the 
plant prefab called _plantPrefab in the Player script, and the UI found in Canvas. The seeds were included written code 
rather it being its own gameObject, written in the script as _numSeeds, _numSeedsPlanted, and _numSeedsLeft. 

The Player gameObject kept the same attributes as I predicted in the breakdown, having it's bunny sprite in its SpriteRenderer 
component. The number of seeds it starts with at the beginning of the game is established in line 19 in the Player script, starting 
with 5 seeds. As the player plants seeds, math done to calculate how many seeds have been planted and how many the player has left
is done in method PlantSeed(); only if the player hits spacebar and has more than zero seeds (if statement done on line 48). 
The player's mobility mechanics are established in the Update(); method, from line 34 to line 44. The _plantPrefab has its one 
attribute which is its sprite in its SpriteRenderer component. 

The script follows the breakdown for how the objects affect each other. The _plantPrefab only spawns once the player hits space, 
found at line 48, starting the PlantSeed(); method where Instantiate(_plantPrefab); is executed at the player's exact position, 
found at line 55. The player starts out with only 5 seeds as established with the int _numSeeds = 5; at line 9, and can only plant 5
seeds until they run out as done by the math in the PlantSeed(); method.

When it comes to the UI object of the game, the UI is established as four gameObjects underneath Canvas, UI for the words "Seeds 
remaining," "Seeds planted," and the value amount for both categories. PlantSeed(); does the math to calculate the amount change 
whenever the player plants seeds into the scene and loses seeds from their possession. The amount is then supposed to be updated to the 
PlantCountUI script in line 65 where in that script, UpdateSeeds(); method updates the UI text to display the calculated amounts. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
