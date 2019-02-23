# NES-ONLINE Game-Auto-Injector Mod
![noga_3 5](https://i.imgur.com/iWBX85v.png)

* You need the NvnTexpkg.package
* Extract NvnTexpkg.package into the same folder like NES-ONLINE Game-Auto-Injector
* You have to create two images (PNG / JPG or TGA32bit), once witch a size of 400x300 and another in the size of 355x512 (use Photoshop or whatever you want)
* Also, you need your "lclassics.titlesdb" file


## Legend:

* Sort Title = "Sort of the game"
* Publisher = "Publisher of the game"
* Game Code (Old Format) = "unique 5 letters combination between AAAAA and ZZZZZ (like "ABCDE")
* Game Code (New Format) = "unique 5 letters combination between NxxxE and NxxxE (like "NABCE")
* Copyright = "Copyright holder of the game"
* Game Title = "Title of the Game"
* Overscan = "only 1 number between 0 and 9 per box"
* Simultanus ="true or false"
* Fade In = "only 1 number between 0 and 9 per box"
* Volume = "a number between 0 and 99"

Output folder: (NESONLINEGameAutoInjectorMod).path/NES_ONLINE_MOD

# Changelog
##Version 1.3.5M (3.5) (The Myth 1.3.5M)
* Fixed Game Code Generation, no more exeptions
* Fixed Game Title Generation, Tool will remove all Special Characters from the Game file opened
* Fixed Thorow Exption Error When Canaceling Open Rom File dialog
* Added Extra Checks For Game Code & Game Tiltele Generation scripts to insure stability


## Version 1.3M (3.5) (The Myth)

* Fixed Output Directory Name, Dosn't Show GameCode Anymore in Game directory Name
* Fixed Wrong GameCode Output inside the GameDir which Caused freezes in Nes Online when Starting the game
* Now New Format is set By Default 
* Forced the Game Dir Name to UpperCase
* Added Screnenshot Preview 
* Added Numeric input for the Volume since I forgot about it last time
* Minor UI Changes and Untility improvement
* Added New Format Game Code Check, Utility won't let you to inject the Newformat if Game code isn't NxxxE
* Added Game Code Fix Pattern to make sure the Game code is correct for new format
* Added Player Count + Release Date and lcla6 input support. This is only for the new format US/EU as of now
* Minor Bug fixes and skipped to Version 1.2 


## Version 1.1M (3.5) (The Insomnia 1.1M)

* Changed from text input fields to numeric input for numbers

## Version 1.0M (3.5) (The Insomnia)

* Added new/old format support which can be chosen from the dropdown menu
* Minor UI modifications
* Auto-fill support added, some fields gets filled automatically now
* GameTitle| Generated from the opened ROM name 
* GameCode | Generated random code using the ROM file's name characters; the other fields are already filled
* Generate the normal game dirictory, this is the name from game's title
