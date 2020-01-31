using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prize_Machine
{
    class Machine
    {

        private Dictionary<String, String> possibleprizes = new Dictionary<string, string>();
        private Random rng = new Random();

        public Machine()
        {
            // fill the machine to start
            Fill();
        }

        public Dictionary<String,String> PossiblePrizes
        {
            get { return possibleprizes; }
        }

        // lists all possible prizes
        public void PrizeList()
        {
            foreach (KeyValuePair<String,String> item in possibleprizes)
            {
                Console.WriteLine(item.Key + ": " +item.Value);
                Console.WriteLine();
            }       
        }

        // generates random prize
        public KeyValuePair<String, String> Generate()
        {
            int randomnum = rng.Next(0, PrizeCount());
            int i = 0;

            foreach (KeyValuePair<String, String> item in possibleprizes)
            {

                if (i == randomnum)
                {
                    return item;
                }

                i++;
            }

            // u shouldnt get this one lol
            return new KeyValuePair<string, string>("You lose!", "Good day sir!");
        }

        // counts how many prizes can be obtained
        private int PrizeCount()
        {
            int i = 0;

            foreach (KeyValuePair<String, String> item in possibleprizes)
            {
                i++;
            }

            return i;

        }

        // fills dictionary with items
        private void Fill()
        {

            // add some stuff
            possibleprizes.Add("Red Nail Polish", "A bottle of high-end nail polish. Advertises being chip-free.");

            possibleprizes.Add("Lipstick", "A tube of bright coral-red lipstick. Apparently made without animal testing.");

            possibleprizes.Add("Matryoshka Doll", "These types of dolls originally come from Russia. " +
                "They are delicately painted, usually by hand.");

            possibleprizes.Add("Pop Music CD", "A CD from one of the latest pop stars. The price tag is still on it.");

            possibleprizes.Add("Broken Glasses", "A pair of glasses that appear to have been stepped on.");

            possibleprizes.Add("Wilted Flowers", "Flowers that have been dead for some time. " +
                "The edges of their petals are beginning to crumble.");

            possibleprizes.Add("Flower Backpack", "A backpack featuring a cute floral pattern.");

            possibleprizes.Add("Notepad", "A somewhat tough-looking notepad. The pages don't fold or tear easily.");

            possibleprizes.Add("Forgotten Letter", "Oh? Who could this be for? It doesn't have a return address.");

            possibleprizes.Add("Game System", "An older game system. The plastic on the outside seems a bit faded and worn.");

            possibleprizes.Add("Pretty Scarf", "A cozy-looking scarf. Appears to be lined with fleece on one side.");

            possibleprizes.Add("Hair Ties", "A pack of seventy-two multicolored hair ties. Who could possibly need so many of these?");

            possibleprizes.Add("Broken Cup", "Perhaps the crack in the side of this mug can be mended. It's painted a pale blue.");

            possibleprizes.Add("Maple Leaf Patch", "A red patch shaped like a maple leaf. " +
                "The adhesive on the back can be stuck to whatever fabric you'd like.");

            possibleprizes.Add("Remote-Control Car", "A beat-up toy car controlled by a remote.");

            possibleprizes.Add("Gift Card", "Where can this be redeemed? Who knows -- the store logo's been scribbled off.");

            possibleprizes.Add("Paint Brush", "A large paint brush with flat bristles.");

            possibleprizes.Add("Fashion Magazine", "A magazine advertising this year's latest fashions.");

            possibleprizes.Add("Horror Novel", "A novel written by an upcoming writer. The cover shows a single eyeball, drawn in gold.");

            possibleprizes.Add("Wireless Mouse", "The plug in this mouse's base can be connected to a laptop's USB port.");

            possibleprizes.Add("Bamboo Sword", "A sturdy bamboo sword. It appears unused.");

            possibleprizes.Add("Crown", "A crown constructed from gold plastic.");

            possibleprizes.Add("Water Bottle", "A brightly-colored water bottle. The sides are covered in stickers.");

            possibleprizes.Add("Broken Watch", "A fashion watch that is missing its hour hand. It appears well-worn.");

            possibleprizes.Add("Microphone", "The paint is chipping off its base, but it still appears to function normally.");

            possibleprizes.Add("Plastic Rose", "The petals feel like they're made from a tough fabric.");

            possibleprizes.Add("Fake Nails", "A package of gaudy fake nails featuring the ugliest designs you've ever seen.");

            possibleprizes.Add("Stylus", "A standard drawing stylus, for use with a drawing pad. The nib looks brand new.");

            possibleprizes.Add("Glass Eye", "Why is this in a prize machine? Isn't that some sort of biohazard?");

            possibleprizes.Add("Pencil Box", "A box made from sturdy pink plastic.");

            possibleprizes.Add("Running Shoes", "Press B to run with these new running shoes! Obtained from a random old man in Cherrygrove City.");
        }
    }
}
