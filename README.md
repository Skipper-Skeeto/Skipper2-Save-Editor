# Skipper & Skeeto 2 Save Editor
A simple Windows Form program that allows modification of Skipper &amp; Skeeto 2 save files

## What?

Skipper and Skeeto 2 is a game developed by Ivanoff Interactive for Windows PCs in 1996, the game was only released in Europe and is pretty hard to come by nowadays. A very small group of people are now getting interested in speedrunning the game, so I developed this tool to help practice by being able to modify values in the game's save files.


## How to use

Click the 'Load Save File' button after launching the program, and navigate to your Skipper and Skeeto 2 save file (You must have a save file already, if you do not have one, simply start the game and save as soon as you gain control).
You can usually find your save files in **C:/Program Files (x86)/Skipper2/**, however on some computers if the game was not installed as administrator, the files can sometimes be redirected to **C:/Users/username/AppData/Local/VirtualStore/Program Files (x86)/Skipper2**.

*NOTE that 'Skipper2' may be different depending on your locale (For example in Denmark or Sweden it is 'Magnus2')*

Once you open the save file, you should see the form change to reflect the values of your save, you can then edit these values and then click the 'Save Changes' button at the bottom of the form to save the file.

You do not have to quit the game to edit or reload a save, simply pause the game and load the save as you would any other time.

## Values

| Name  | Purpose |
| ------------- | ------------- |
| **Room**  | Changes the current room that the player is in, from a list of all available rooms.  |
| **Minute Hand**  | A value from 0-59 that changes the minute hand on the clock.  |
| **Bonus Minutes** | The number of 'bonus minutes' that are available in the inventory after collecting a forgotten moment |

| Name  | Purpose |
| ------------- | ------------- |
| **Unlock Clock Tower** | Unlocks the Clock Tower Door |
| **Unlock Dining Room** | Unlocks the Dining Room Door |
| **Trigger Armor Axe** | Triggers the suit of armor in the main hall to chop the sphere on the staircase |

Inventory items are self-explanatory.

## To Do

- [x] Room Teleporting
- [x] Time editing
- [x] Forgotten Moments editing
- [x] Inventory modification
- [ ] Change save thumbnail based on current room
- [ ] Unlock all doors
- [ ] Display all other variables
- [ ] Add backup-before-saving option
- [ ] Implement save file dialog

## Extras

Check out the [Speedrun Leaderboard](https://www.speedrun.com/skipper2) for the game
Join our [Discord server](https://discord.gg/jGgXAWT)
