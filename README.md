CHEESE CHASE

Design doc: 
https://docs.google.com/document/d/e/2PACX-1vRkkc1Xt-fPcJ-_EXEq81VRGzAkihPtbhBf-oW-OwsbZ8BIV9Gn9Il6a-4R8U-snYMyFPzdrW786tOy/pub

Goal:
The goal of the game is to eat all of the cheese, however the different flavors have different abilities.

Narrative:
Cheese. You love cheese. Unfortunately, cheese molds. Try and eat all the cheese you can before it molds! You won't want to eat moldy cheese! 
That cheap American cheese in plastic wrap and its processed self will be real easy to eat. Even when it molds you might find that it draws itself nearer and nearer to you. 
Swiss cheese, with its charming holes, is certainly tasty, but can be quite hard to come by. You might get hit right it the face by one well after it has molded.
Colby/Pepper Jack cheese is a tasteful adventure, but incredibly difficult to find. In fact, sometimes it feels as though it is running away from you!

Mechanics:
Point and click on the menu.
Use WASD or Arrow Keys to move around and collect the cheese.
The different flavored cheeses have different AI capabilities that make them either drawn to you, move randomly, or run away from you. In theory you must strategically move the player to collect the cheeses.
There are boundaries on the four sides of the playable area to ensure that the cheeses, and the player does not go too far off track.

Aesthetics:
There are three different cheese flavors and they turn green and moldy and attract flies after some time. 
The piano music in the menu and for each level highlight the difficulty of the moment.
The goal was to have a minimalistic design.

Joys:
Making the sprites, menus, and NPC scripts was not too dificult and this was enjoyable to do as the game came together.

Struggles:
Merge-conflict meltdown at the end. We had two different repositories and this caused a lot of problems. Eventually things mostly got worked out.

Attributions:
Cheese sprites: Tucker Brock
Player sprite: Noah Morris
Music: 
        Menu: Piano IIX by onky on OGA
        Level 1: Piano piece by RobinJ24 on OGA
        Level 2: Bar jazz piano song by VViard on OGA
        Level 3: Darkness Falls by Matthew Lagoe on OGA
        Eating sound: https://soundbible.com/976-Eating.html 
Font: RubikMonoOne - Regular

Contributions:
In the beginning, we collaborated to plan the game and made a design document. We gave ourselves deadlines to meet the required tasks. Amelia set up the menus, transitions, SceneManager, fonts, and canvas. Tucker made the cheese sprites, selected the music, added PlayerMovement and FollowCam scripts, and wrote the ReadMe. Noah wrote the different scripts for the different cheeses and combined the code together after the merge conflict (fully making the game playable), and uploaded everything to itch.io (solving an ugly JavaScript error in the process).
