# DragonPirates

## Team

| Carl | Chris | Danny | Jake | Remy |
| ---- | ----- | ----- | ---- | ---- |
|<a href='https://github.com/carlfjones'><img src='https://user-images.githubusercontent.com/23095774/60434119-56192e00-9bfe-11e9-8156-26105b51e0d7.png' width='40'></a>|<a href='https://github.com/chris-groves'><img src='https://user-images.githubusercontent.com/23095774/60434119-56192e00-9bfe-11e9-8156-26105b51e0d7.png' width='40'></a>|<a href='https://github.com/danielandro'><img src='https://user-images.githubusercontent.com/23095774/60434119-56192e00-9bfe-11e9-8156-26105b51e0d7.png' width='40'></a>|<a href='https://github.com/binaryred01'><img src='https://user-images.githubusercontent.com/23095774/60434119-56192e00-9bfe-11e9-8156-26105b51e0d7.png' width='40'></a>|<a href='https://github.com/indecentdolphin'><img src='https://user-images.githubusercontent.com/23095774/60434119-56192e00-9bfe-11e9-8156-26105b51e0d7.png' width='40'></a>|

### Instructions for use:

* Install Unity
* Open DragonPiratesTeam folder in Unity
* Press the play button
* Click on screen to simulate user touch

### Instructions for use on Android Mobile devices

* Use android file transfer on laptop to drag and drop the ./DragonPiratesAndroidTest.apk

## DEVELOPER INSTRUCTIONS

* Deploying Unity App
- - Download Android SDK Tools from the internet
- - Locate the tools in Unity via Preferences/External Tools (it should auto find)
- - In Unity, create a key using Keystore: <br> <br> Go to File/Build Settings, select Android in Platform and click Player Settings... Here you will find the Keystore Manager. Select from the dropdown: select existing. Then browse to ./KEYSTORE.keystore. <br> Then use the password to load the key. <br> You will now be able to go to Build Settings again and Build the application. <br> Follow the "Instructions for use on Android Mobile devices" to load the app on a device.

## Credits
“Foggy Forest” menu loop by PlayOnLoop.com
Licensed under Creative Commons by Attribution 4.0

Menu scene by <a href="https://www.freepik.com/free-photos-vectors/water">Water vector created by brgfx - www.freepik.com</a>

"Countdown to Myocardial Infarction" main game loop by Peter Gresser

"Race Start Beeps" by Ulrich Metzner (remixed by qubodup)


### Technology Stack:

* Unity - Game Engine
* C# - Script Language
* Xunit - Testing Framework

### MVP

For the MVP we have a basic game. In which the dragon main character can infinitely fly through the level, avoiding pirates and flying through scorezones.

### Version 1 - In progress

- [ ] User can enter their name so that their score can be logged.
- [x] User can Start game to initialise Dragons of The Pirates.
- [x] User can press the screen to make the Dragon fly.
- [x] User can guide the Dragon between the parrot and the Pirate enemy, to gain a score point
- [x] User can see their score
- [x] User can die if the Dragon lands
- [x] User can die if the Dragon is hit by a Pirate
- [x] User can see Game Over screen when the Dragon has died
- [ ] User can see their position on LeaderBoard when game over

### Version 2 - backlog
