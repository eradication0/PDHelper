# PDHelper  
A simple app to edit the memory of Phantom Dust to give max out credits/skills aswell as load/edit/backup any arsenal you want.  
The app will not connect to anything that is not Phantom Dust, so no random edits on any other process can occur.  
[[Download V3.1 (latest)(https://github.com/eradication0/PDHelper/releases/download/ReleaseV3.1/PD.Helper.V3.1.zip)
  
# Disclaimer
- Use this software on your own risk!  
- PDHelper is not perfect!
- I recommend backing up all your arsenals first!  
- Worst case scenario you will lose your profile and everything associated with it like hours played, creation date and Singleplayer Progress  
- If you value that, use this software on a secondary profile  
  
# How To Use  
[Youtube Tutorial (6min)](https://www.youtube.com/watch?v=uSrHAq2tW78) (kind of outdated)

# closed game use (by @jessep13)
1. start PD Helper
2. edit/save your arsenals, no longer need to have the game open

# open game use
if you want to write the arsenals into the game itself you need to
1. start Phantom Dust
2. open a profile
3. click "load profile"
 
# Requirements
.NET 6.0.5 x64
[Download .NET (6.0.5)](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-6.0.5-windows-x64-installer)
  
# Arsenal Features
- **Save Arsenals** directly into the game  
- **Backup Arsenals** as a file to store infinite Arsenals that can be loaded at any time  
- **Share Arsenals** via just sending the file, no more recreating Arsenal via screenshot  
- **Edit Arsenals** between games to optimize Arsenals on the fly  
- **Change Arsenal Case Type** directly, no more need to delete and buy a new case  
- **Rename Arsenal**s directly, allowing more special characters than in-game
- **Offline Edit** edit/save/share arsenals without having having Phantom Dust open (by @jessep13)
- **Color Coded Skills** to match the in-game colors (by @jessep13)

# Skill Filtering (by @@jessep13)
- **Basic Filter** sort skills by school/type/range
- **Advanced Filters** limit skills to min/max per stat
- **Sorting** tripple sorting ordering
  
# Other Features  
- **Max out credits and skills** to make the game a even playing field for everyone  
- **Toggle Team Lock-On** even during a match to make support decks more viable  
- **Anti Cheat Mechanisms** are in place to prevent creating normally impossible arsenals    
  
# Anti Virus Issues and False Positives
PDHelper strictly can only edit the process called "PDUWP" (Phantom Dust Universal Windows Platform)
Because the game is fully in binary and we dont have access to a single line of code, all we do is read/write into the memory directly. This is basically changes the software in real time. Thats why Windows Defender and other Anti Virus softwares dont like it.
Phantom Dust itself has no anti cheat or detection, so far not a single person has been banned or warned even though we are using PDHelper online.
Almost everyone in the PD Community uses this app and can vouch for it being valid.
If you are still concerned, the app is fully open source, feel free to look through the code and make up your own mind.

# How to allow the app through windows defender
1. Start the app and click allow
2. Start again, if nothing happens, open up windows defender
3. Start it again and it will pop up inside Windows Defender
4. Click "Allow Software" in order to use tha app
[VirusTotal Scan](https://www.virustotal.com/gui/file/d6ce7f94256864e6edac26b0356d5b0b8156c2ce42c69c8694eaf7dda2ec6db5?nocache=1)

# How it works 
Basically im using a library called [memory.dll](https://github.com/erfg12/memory.dll) it allows to read, search and write memory directly into applications. The rest of all the files/code just comes with VisualStudio and their .net library stuff. 
  
# Credits
## Made by Nuion
## Huge help by @jessep13 for the quality of life changes and filtering features
check out [phatomdust.online](https://phantomdust.online/) for everything Phantom Dust related
  
Thanks to the testing group helping to find bugs  
Fatnerd, Xanxus, Inflim, MysticNinja, Show, SnowRyze, Toaf, Treat, TripL, Algol, Bregan and Esper28
 
