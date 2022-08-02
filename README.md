# PDHelper  
A simple app to edit the memory of Phantom Dust to give max out spells and credits.  
The app will not connect to anything that is not Phantom Dust, so no random edits on any other process can occur.  
Download: https://github.com/eradication0/PDHelper/releases/download/Release/PD-Helper-v1.1.exe  
  
# How To Use  
Everything is explained inside the application, still here is how it works

1. Open the app while the game is running
2. Click "Attach" to attach the Phantom Dust process
3. Click either "Max Skills" and/or "Max Credits"
4. (optional) if a graphical bug happens in the LAB tab, sell a single "Phantom Dust" skill in the shop to fix it
 
## Requirements
### .NET 6.0.5 x64
Download from [Microsoft.com](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-6.0.5-windows-x64-installer)
 
# How it works
Basically im using a library called [memory.doll](https://github.com/erfg12/memory.dll) it allows to read, search and write memory directly into applications.  
  
## Max Credits
Its simple, I just edit a single byte that represents the highest number of the credit value.  
Memory Pointer: ``base+003ED640`` with an offset of ``13B``  

## Max Skills
Same thing, just this time I loop through a list of 374 bytes to set the inventory to 99 on each one.  
Memory Pointer: ``base+003ED6B8`` with an offset of ``644`` to ``7BA``  
  
# Credits
## Made by Nuion
check out [phatomdust.online](https://phantomdust.online/) for everything Phantom Dust related  
  
thanks to guild "Octo Dazzle" for helping out
