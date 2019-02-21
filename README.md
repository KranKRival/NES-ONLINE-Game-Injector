# NES-ONLINE-Game-AutoInjector Mod By KranK/KuranKu
![noga_3 5](https://i.imgur.com/iWBX85v.png)

- You need the NvnTexpkg.package
- Extract NvnTexpkg.package into the same folder like NES-Online-Game-Autoinjector
- You have to create two images (PNG / JPG or TGA32bit), once witch a size of 400x300 and another in the size of 355x512 (use Photoshop or whatever you want)
- Also, you need your "lclassics.titlesdb" file


Legend:

- Sort Title = "Sort of the game"
- Publisher = "Publisher of the game"
- Game Code (Old Format) = "unique 5 letters combination between AAAAA and ZZZZZ (like "ABCDE")
- Game Code (New Format) = "unique 5 letters combination between NxxxE and NxxxE (like "NABCE")
- Copyright = "Copyright holder of the game"
- Game Title = "Title of the Game"
- Overscan = "only 1 number between 0 and 9 per box"
- Simultanus ="true or false"
- Fade In = "only 1 number between 0 and 9 per box"
- Volume = "a number between 0 and 99"

Output folder: (NES-Online-Game-Autoinjector).path/NES_ONLINE_MOD

#Version 1.3M (3.5) (The Myth)

- 1.Fixed Output Directory Name, Dosnt Show GameCode Anymore in Game Dirictory Name
- 2.Fixed Wrong GameCode Output inside GameDir wich Caused freeze in Nes Online While Starting the game
- 3.Now New Format Is set By Default 
- 4.Forced Game Dir Name To UpperCase
- 5.Added ScreenShot Preview 
- 6.Added Numeric input for Volume cause forgot about it last time
- 7.Minor Ui Changes and Tool Movment
- 8.Added New Format Game Code Check, Tool wont Let you to inject Newformat if Game code isnt NxxxE
- 9.Added Game Code Fix Pattern To make fure the Game code is correct for new format
- 10.Added Players Count + Release Date and lcla6 Input support / only new format US/EU For now
- 11.Minor Bug fixes and Skip Version 1.2 xD


#Version 1.1M (3.5) (The Insomnia 1.1M)

- 1.changed from text input feilds to numeric input for numbers

#Version 1.0M (3.5) (The Insomnia)

- 1.added new/old format support choose from dropdown menu
- 2.minor ui modifications for better exprience 
- 3.auto fil support added , some fields gets filled automaticly
- #GameTitle - genereted from the opened rom name 
- #GameCode - genereted random code using rom file name letters
- #the other fields just preset, easy life :)
- 4.generate normal game dirictory name from game title
