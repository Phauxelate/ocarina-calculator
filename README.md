# ocarina-calculator

Hello, and welcome to my repo!

My end goal for this is to allow anyone any everyone to be able to use these equations and thought process I've figured out. I want this to be completely free and open to use, as some knowledge should not be held behind a wall.

This program calculates the diameter of finger holes for an ocarina (or possibly some other similar instrument). I have not found a single source that showed how to do this either mathematically or programmatically, so I decided figure it out myself.

All units are in inches and hertz. (I hope you like the Imperial System)

To start, enter a desired fipple diameter. All other measurements are based off of this value, so you'll need to choose something semi-random for this. For an AC ocarina, this could be around 0.3 inches.

Next, enter the base frequency of the ocarina. This is the frequency where every finger hole is closed (including sub holes, if they are to be added).

Now here's the funky part: The way the diameter of holes is calculated is by the total area of open holes. So, to start calculating the holes, you'll need to choose a note higher than what you want for it to be physically open. When you calculate the last hole (On a 12 hole AC Ocarina this would be F with a frequency of 1396.91 Hz), that hole will be open if you try to physically play the note, so you won't need a higher note frequency for it.

After each calculation, the program spits out a text file containing the measurements in the same folder so you won't have to manually record them.

If you add in a number wrong, you must press restart and try again. The hole diameters are linked to each other, which means you can't just ignore that you just added an unwanted hole into your measurement calculations!

I've spend a lot of man hours on this! Tell your friends, as this could lead to something big someday!


As of 08/30/2019, these equations have been mathematically and visually proven to work. But I am no 3D modeler, so I need people to try design a physical product for verified proof of concept!
