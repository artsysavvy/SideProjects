using System;
using System.Collections.Generic;

namespace prizemachine
{
    class Program
    {
        public void Main()
        {
            var l = new Dictionary<String, String>();

            // inventory
			Dictionary<String, short> inv = new Dictionary<string, short>();
			inv.Add("gamer time", 0);

			Console.WriteLine(inv[0]);
            
            // add some stuff
            l.Add("Red Nail Polish","A bottle of high-end nail polish. Advertises being chip-free.");

            l.Add("Lipstick","A tube of bright coral-red lipstick. Apparently made without animal testing.");

            l.Add("Matryoshka Doll","These types of dolls originally come from Russia. " +
                "They are delicately painted, usually by hand.");

            l.Add("Pop Music CD","A CD from one of the latest pop stars. The price tag is still on it.");

            l.Add("Broken Glasses","A pair of glasses that appear to have been stepped on.");

            l.Add("Wilted Flowers", "Flowers that have been dead for some time. " +
                "The edges of their petals are beginning to crumble.");

            l.Add("Flower Backpack", "A backpack featuring a cute floral pattern.");

            l.Add("Notepad", "A somewhat tough-looking notepad. The pages don't fold or tear easily.");

            l.Add("Forgotten Letter", "Oh? Who could this be for? It doesn't have a return address.");

            l.Add("Game System", "An older game system. The plastic on the outside seems a bit faded and worn.");

            l.Add("Pretty Scarf", "A cozy-looking scarf. Appears to be lined with fleece on one side.");

            l.Add("Hair Ties", "A pack of seventy-two multicolored hair ties. Who could possibly need so many of these?");

            l.Add("Broken Cup", "Perhaps the crack in the side of this mug can be mended. It's painted a pale blue.");

            l.Add("Maple Leaf Patch", "A red patch shaped like a maple leaf. " +
                "The adhesive on the back can be stuck to whatever fabric you'd like.");

            l.Add("Remote-Control Car", "A beat-up toy car controlled by a remote.");

            l.Add("Gift Card", "Where can this be redeemed? Who knows -- the store logo's been scribbled off.");

            l.Add("Paint Brush", "A large paint brush with flat bristles.");

            l.Add("Fashion Magazine", "A magazine advertising this year's latest fashions.");

            l.Add("Horror Novel", "A novel written by an upcoming writer. The cover shows a single eyeball, drawn in gold.");

            l.Add("Wireless Mouse", "The plug in this mouse's base can be connected to a laptop's USB port.");

            l.Add("Bamboo Sword", "A sturdy bamboo sword. It appears unused.");

            l.Add("Crown", "A crown constructed from gold plastic.");

            l.Add("Water Bottle", "A brightly-colored water bottle. The sides are covered in stickers.");

            l.Add("Skateboard", "A skateboard with neon-colored wheels. It appears to have recently gotten a paint job.");


        }

        public void InventoryCheck()
		{
            foreach (String obj in inv)
			{
				short temp = inv[obj];
				Console.WriteLine(obj+" x");
			}
		}

		public void InventoryAdd()
		{

		}
	} 
}
