using LennyAPI.Stuff;
using System;
using System.Reflection.Metadata.Ecma335;

namespace LennyAPI
{
    public class Lenny
    {

        public static void SayHello()
        {
            Console.WriteLine("[Lenny] Said hello!");
        }

        public static LennyInventory Inventory = new LennyInventory();

        public static void Give(LennyItem item)
        {
            if (Inventory.HasItem(item))
            {
                Inventory.AddItem(item);
            }
            else
            {
                Console.WriteLine("[Lenny API] Somebody just tried to give Lenny something he already had! He doesn't want that (unless it's megan!) :(");
            }
        }

    }


}
