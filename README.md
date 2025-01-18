[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects
- UI
    - Seeds planted UI
        - Attributes: text
        - Actions: count goes up when player plants a seed
    - Seeds remaining UI
        - Attributes: text
        - Actions: count goes down when player plants a seed
- Player
    - Attributes: Bunny Sprite
    - Actions
        - Movement
            - Input: WASD
            - Output: Player changing location
        - Planting seeds
            - Input: Space
            - Output: If player has seeds remaining: 1 seed is planted at player’s location; decreases seed count + increases plant count (shows in UI)
- Plants
    - Attributes: Plant sprite

## Devlog
I finished this assignment very quickly and I am so proud of how much I've learned and retained from last quarter. I referenced my scripts in assignments from GDIM 31 to help me write code for this assignment. In my breakdown, I note that the UI decreases/increases each time the player plants an item with Space. In my code, I called the UpdateSeeds() method from the PlantCountUI script each time a player pressed space (which planted a seed) and input (_numSeedsLeft, _numSeedsPlanted) as the argument to fit the (int SeedsLeft, int SeedsPlanted) parameters and update the numbers accordingly. Additionally, my breakdown notes that a player can only plant a seed if they have seeds remaining to plant. In my code, I made it so that the PlantSeed() method is only called if the player presses Space AND if _numSeedsLeft is greater than 0. Otherwise, nothing happens.

I had some trouble with the UI when building because I forgot to anchor the text, but I figured it out.

Overall, this assignment has shown me my growth since the beginning of GDIM 31 and I think the pieces are starting to fit together.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for describing a clear connection between your breakdown and the code you wrote. This Devlog will recieve full marks for answering the prompt clearly- keep it up for HW2! :) 

> Overall, this assignment has shown me my growth since the beginning of GDIM 31 and I think the pieces are starting to fit together.

Woohoo! :D

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and make sure the activity and Devlog are in the correct sections. Also, you can remove the prompt text. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
