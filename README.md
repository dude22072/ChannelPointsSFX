# ChannelPointsSFX
A program for having sound files play when a user redeems a Channel Points reward on Twitch.

## Setup
Upon first launch of the program a propmpt will show up asking for your Twtich ChannelID  
![Please enter your Twitch ChannelID (THIS IS NOT YOUR USERNAME)](https://i.imgur.com/gS5W1Pg.png)  
As the image says if you do not know your ID you may use https://dude22072.com/twitchchannelid.php to find it.  
  
After this you will be presented with the main window of the program, looking like this:  
![Main program window without any items](https://i.imgur.com/8h3X9As.png)  
Right away you'll notice the volume bar along the bottom. Changing this will change the volume for all alerts from that point on. It will not change the volume of currently playing alerts.  
Above the volume slider you will see the "Emercency Stop" button. This button (should) stop all currently playing sounds. Useful for when multiple users decide to spam a sound all at the same time and the overlap gets to be too much.  
And yet above that you will see the "Add Sound" button. When clicked, it will first give you a dialog asking to evter the name of the channel point reward EXACTLY as it appears on twitch, as this is what it uses to know when the reward has been redeemed. It will then show a file select dialog to select a sound file. The program will play any format that works in the default windows audio player.  
  
After you've added a few sounds a few more buttons will become available to you:  
![Main program window with two items](https://i.imgur.com/1EuKBB3.png)  
The buttons along the right side of the list are for moving between the items on the list.  
The "Test Sound" button will play the currently selected sound as if a reward had been redeemed. Useful for making sure you've selected the right file and testing how loud it is at your current volume level.  
The "Delete Sound" button will remove the currently selected sound.  
This should be all you need to know to get started. Any more questions read the FAQ below.  
  
## FAQ  
**Q: I think I put the channel ID in wrong... how do I change it?**  
A: Press the gear icon in the bottom-right of the main window to open the options window. Click the "Reset ID" button and follow the instructions on screen.
  
**Q: Do I need the program open while I'm streaming?**  
A: Yes, the sounds come from the program itself.  
  
**Q: How will the sounds come through on OBS?**  
A: Desktop Audio  
