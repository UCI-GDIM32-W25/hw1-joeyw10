[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Objects
    UI
        Seeds planted UI
            Attributes: text
            Actions: count goes up when player plants a seed
        Seeds remaining UI
            Attributes: text
            Actions: count goes down when player plants a seed
    Player
        Attributes: Bunny Sprite
        Actions
            Movement
                Input: WASD
                Output: Player changing location
            Planting seeds
                Input: Space
                Output: If player has seeds remaining: 1 seed is planted at player’s location; decreases seed count + increases plant count (shows in UI)
    Plants
        Attributes: Plant sprite

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

I finished this assignment very quickly and I am so proud of how much I've learned and retained from last quarter. I referenced my scripts in assignments from GDIM 31 to help me write code for this assignment. In my breakdown, I note that the UI decreases/increases each time the player plants an item with Space. In my code, I called the UpdateSeeds() method from the PlantCountUI script each time a player pressed space (which planted a seed) and input (_numSeedsLeft, _numSeedsPlanted) as the argument to fit the (int SeedsLeft, int SeedsPlanted) parameters and update the numbers accordingly. Additionally, my breakdown notes that a player can only plant a seed if they have seeds remaining to plant. In my code, I made it so that the PlantSeed() method is only called if the player presses Space AND if _numSeedsLeft is greater than 0. Otherwise, nothing happens.

Overall, this assignment has shown me my growth since the beginning of GDIM 31 and I think the pieces are starting to fit together.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
