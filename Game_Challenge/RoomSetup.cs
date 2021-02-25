using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    public class RoomSetup
    {
        public static void SetupRooms(Room[] _rooms)
        {
            // new Room parameters are: name, exits 1 - 4, sound : You listen carefully and hear, smell: You sniff the air and can smell, description   -JP

            _rooms[0] = new Room(0, "north", "west", "", "the faint odor of food coming from the north", "You are in a small room that feels cramped. You can see some light coming from a small archway to the north as well as one to the west.");
            
            //Pantry
            _rooms[1] = new Room(1, "north", "south", "east", "west", "what sounds like a deep growl coming from the east", "little scraps of food all around the room", "The floor of this room has debris scattered around. There are door ways leading to the north, south east and west.");
            
            // death room :(
            _rooms[2] = new Room(2, "west", "", "", "As you walk into this room you see a giant cat grinning widely at you. As you turn to run you feel claws dig into you and the last thing you see is the light from the doorway fading as you breathe your last breath.");
            
            //Here is where I started   -JP
            //Kitchen area
            _rooms[3] = new Room(3, "north", "south", "east", "west", "the sounds of water bubbling in a pot, a soft clanking coming from a room to the north, and from the east you can hear some kind of rustling from that direction. Who knows what that could be?", "garlic, onion, some kind of.... Hmm. Parsley maybe? Thyme? You're not sure.", "You find yourself greeted with cold tile and hot air. Looking around, there are even more crumbs here as well as scraps of produce that Probably didn't make it into the rubbish bin. You gather this is a kitchen, and a somewhat active one at that....\nLooking around, you see some things you could probably crawl behind to the south and the west.....");

            //Dining Room
            _rooms[4] = new Room(4, "north", "south", "east", "west", "that the clinking sound has gotten much louder, joined by laughter and conversations by people eating at a table. You also hear music and humming coming from the east.", "that whatever was cooked here, presumably, came from the south. You also catch whiffs of the women's perfumes and the men's cologne.", "Upon entering, you realize that you're surrounded by people much larger than you. Thankfully they're preoccupied with whatever heavenly smells are on the table. To the north you see a corridor with paintings hung up.");

            //Hallway
            _rooms[5] = new Room(5, "north", "south", "east", "the raucous laughter from the dining room to the east.", "more tasty scents wafting to you from the south through this hallway. Odd that it connects twice, but that just means more acrumptious smells. Yum.", "You are in a large hallway, adorned with hardwood floors and a running floor rug. Not very much space to hide. To the north you can see bright lights. ");
            
            //Parlor area?
            _rooms[6] = new Room(6, "north", "south", "west", "so much noise that it's hard to focus on one single piece. You hear laughing and conversations, and some snappy jazz being played from a large machine to the south. You could probably squeeze behind that....", "You smell sweat and perfumes and colognes. Hard to pinpoint anything really.", "Upon arrival you have to hide in the corner to avoid beign stepped on! Theres a lot of people here dancing and having fun. To the west you can see a large opening leading to the dining room, where people are seated and eating. To the north you can see a door cracked open slightly. Perhaps this could be a nice place away from so many large dangers....");

            //Bedroom area?
            //You said to have east removed here, but I am unsure how to implement that as far as the strings go in connectingRooms, however I have added "West"    -JP
            _rooms[7] = new Room(7, "north", "south", "west", "that in this room, a lot of noise from the south is muffled. It's quiet, but not silent. Not in a spooky way, but cozy almost.", "the mesmerizing scent of fresh linens and lavender. It smells like a nice warm hug on a spring day.", "Looking around here, you see a large bed, neatly made. You see a closet to the west that might have a small passageway through to another room as well as another door to the north. Who knows where that will lead. ");

            //Hallway from foyer to bedroom?
            _rooms[8] = new Room(8, "south", "west", "songbirds singing from a large window to the west. How lovely they sound!", "crisp spring air and, as odd as it sounds, the warm sunlight. It smells like a wonderfully perfect day.", "At the south end, you notice a large oak door, with a nice bronze handle. This hallway is warm and comforting. You get the sense that you're probably closer to the outside world than you have been since finding yourself in this house.");

            //Room before exit, foyer
            _rooms[9] = new Room(9, "north", "south", "east", "west", "wind rustling against a door to the south", "that the scent of heat on a spring afternoon wears heavily here. A lot of traffic must come through here.", "This seems to be another hallway. However, this one is different to the others that you have found so far. This one has more furniture that offer great places to hide. But other than that, this room holds more significance than a regular hallway. You see a large oak door to the north and a small door to the south. As well as two long hallways to the east and west.");

            //Closet
            _rooms[10] = new Room(10, "north", "", "mothballs and lots of dusty coats.", "A small closet, littered with shoes and dirt that's been tracked in. You figure this might be a cozy place to make a little home.");

            // Exit / Win
            _rooms[11] = new Room(11, "south", "", "", "As you squeeze through this door, you have to squint as the bright sun hits you in the eyes. The warm spring air greets your little face! Your heart warms as the sun shines down on you and you realize how wonderful of a day it is. You look around to see your spouse not too far away huddled next to a plant on the walkway with your two mouselings. They are all relieved to see that you made it out unharmed and can now find a safer place to make your home.You're free to explore and eat to your hearts content, however, don't get too content! Many new dangers await you out in the wild...");


            SetupExits(_rooms);

        }

        private static void SetupExits(Room[] _rooms)
        {
            // Room 0 connectingrooms
            _rooms[0].connectingRooms = new int[2];
            _rooms[0].connectingRooms[0] = 1;
            _rooms[0].connectingRooms[1] = 3;

            // Room 1 connectingRooms
            _rooms[1].connectingRooms = new int[4];
            _rooms[1].connectingRooms[0] = 6;
            _rooms[1].connectingRooms[1] = 0;
            _rooms[1].connectingRooms[2] = 2;
            _rooms[1].connectingRooms[3] = 3;

            //Room 2 connectingRooms
            _rooms[2].connectingRooms = new int[1];
            _rooms[2].connectingRooms[0] = 1;

            // Room 3 connectingRooms
            _rooms[3].connectingRooms = new int[4];
            _rooms[3].connectingRooms[0] = 4;
            _rooms[3].connectingRooms[1] = 0;
            _rooms[3].connectingRooms[2] = 1;
            _rooms[3].connectingRooms[3] = 5;

            //Room 4 connectingRooms
            _rooms[4].connectingRooms = new int[4];
            _rooms[4].connectingRooms[0] = 7;
            _rooms[4].connectingRooms[1] = 3;
            _rooms[4].connectingRooms[2] = 6;
            _rooms[4].connectingRooms[3] = 5;

            //Room 5 connectingRooms
            _rooms[5].connectingRooms = new int[3];
            _rooms[5].connectingRooms[0] = 9;
            _rooms[5].connectingRooms[1] = 3;
            _rooms[5].connectingRooms[2] = 4;

            //Room 6 connectingRooms
            _rooms[6].connectingRooms = new int[4];
            _rooms[6].connectingRooms[0] = 7;
            _rooms[6].connectingRooms[1] = 1;
            _rooms[6].connectingRooms[2] = 4;

            //Room 7 connectingRooms
            _rooms[7].connectingRooms = new int[4];
            _rooms[7].connectingRooms[0] = 8;
            _rooms[7].connectingRooms[1] = 6;
            _rooms[7].connectingRooms[2] = 4;

            //Room 8 connectingRooms
            _rooms[8].connectingRooms = new int[2];
            _rooms[8].connectingRooms[0] = 7;
            _rooms[8].connectingRooms[1] = 9;


            //I had to change the layout slightly due to room 9 having a north, east, and west exit, but no south. Unless we could have a way to only have those directions?    -JP

            //Room 9 connectingRooms
            _rooms[9].connectingRooms = new int[4];
            //11 is the exit room   -JP
            _rooms[9].connectingRooms[0] = 11;
            _rooms[9].connectingRooms[1] = 10;
            _rooms[9].connectingRooms[2] = 8;
            _rooms[9].connectingRooms[3] = 5;

            //Room 10 connectingRooms
            _rooms[10].connectingRooms = new int[1];
            _rooms[10].connectingRooms[0] = 9;

            //Room 11 ConnectingRooms
            _rooms[11].connectingRooms = new int[1];
            _rooms[11].connectingRooms[0] = 9;
        }
    }
}
