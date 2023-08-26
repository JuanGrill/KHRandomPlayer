# KH Random Player

Play random songs from downloads khinsider.

![Player](https://github.com/JuanGrill/KHRandomPlayer/assets/70032584/a0938fc5-d3b9-4014-bf7e-ad38718d661d)

Features:
- Buffer queue with a customizable limit (Keep loading random songs in background).
- Skip short songs and sound effects with a customizable minimum duration.
- Download current song.
- Hand-made UI.
- Display album cover from current song (If there's one associated with).
- Save album cover image (Right click on cover -> 'Save cover image').
- Customizable background.

## Compilation:
1. Clone the repository and open the .sln file with Visual Studio.
2. Right click on the project and choose 'Publish'.
3. Follow the publish instructions until the end.
4. Run the installer.

## Q&A:
- Why takes too long to fetch a song?
   - At this time, the random song function of the site works a bit slow and sometimes fails to load. So, getting a song could take a while. This issue is parcially solved with the buffer queue.
 
- The program found and played a song who was life changing for me, but it got skipped after it finished and I couldn't download it. Is there a way to find it?
   - Currently, there's no song history. However, its a intended feature, so please stay tuned!
 
- Who is the creature who appears in the cover section and in the program icon?
   - Its Pommy! Please take a look at Bomberman 64 TSA!
 
- The code is a mess. Can I improve it?
   - Yes, you can improve the code, ~~break it, destroy it, dream about it, use it to order pizza~~.

## Troubleshooting:
- The program isn't runnning.
   - Try installing .NET Framework 4.7.2.
 
- The program throws a "Error in server" message constantly.
   - Check your internet connection.
 
- The song doesn't play and there's no "Error in server" message.
   - Check your current configuration. Click on settings (Button with a gear) and reduce the Minimum song length to 30.
 
- The program crashes randomly or there's another issue with it.
   - Woops, maybe its my fault. Please open an issue and I will check it out.
 
## Known issues:
- A slow internet connection may cause the player won't work properly.
- The program could break if the site design (Where the songs are stored) is altered in any way.

## About:
KHRandomPlayer is created by me in collaboration with Richard S.
This program is not affiliated with KHInsider in any way. Please visit the official site and consider donating to maintain its servers: https://downloads.khinsider.com/.

Want to see more of my works? Please visit: https://takumiq.github.io/ and consider donating too. Thank you!
