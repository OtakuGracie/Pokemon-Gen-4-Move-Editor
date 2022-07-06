# Pokemon Gen 4 Move Editor

This a program for editing move data such as power, catergory (physical, special, status), accuracy, and type in the Generation 4 Pokemon game roms
for the Nintendo DS.


THIS PROGRAM ONLY RUNS IN WINDOWS!!!


It has been specifically tested with windows 8.1 and 10.

.NET Framework 4 is required for it to run.

![Pokemon_Gen_4_Move_Editor_preview](https://user-images.githubusercontent.com/73315709/177639394-79e9f9eb-95d8-4676-9a26-8269eaadaff0.PNG)


Features:
* Edit move data (power, accuracy, pp, type, flags such as if it is affected by king's rock, priority, target, and even contest stats) 
  in Diamond, Pearl, Platinum, HeartGold, and SoulSilver either directly from the roms or extracted waza_tbl.narc (aka a/0/1/1 in HGSS)
* Changes can be saved either directly to a selected rom file or to a binary file that can then be spliced into a rom using a tool such as CrystalTile
* Add new move data for the games (WIP)
* Use custom types that do not exist in the vanilla game (ex. Fairy)



Planned Features:
* Reading move and type names directly from the selected roms so that the moves.txt and types.txt files are no longer necessary
* Editing and adding move names so that another tool is not needed for this
* Support for romhacks that do not store move data in the default location


Created in C# with Microsoft Visual Studio as IDE with Windows forms for UI.
