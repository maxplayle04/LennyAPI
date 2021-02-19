using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LennyAPI.Stuff
{
    public class LennyItem
    {
        private static List<string> DiscoveredItems = new List<string>();
        
        public string Name { get; private set; }

        public bool IsDirty { get; private set; }

        public bool IsExpensive { get; private set; }

        public int Quantity = 1;
    
        public LennyItem(string name, bool isSexual, bool isExpensive)
        {
            this.Name = name;
            this.IsDirty = isSexual;
            this.IsExpensive = IsExpensive;
            if (!DiscoveredItems.Contains(name))
            {
                Console.WriteLine("Lenny has discovered a " + name);
                if (isSexual)
                {
                    Console.WriteLine("... that dirty bastard!");
                    if (isExpensive)
                    {
                        Console.WriteLine("... it is a little expensive though so I can sort of understand.");
                    }
                }

                if (isExpensive && !isSexual)
                {
                    Console.WriteLine("God damn, Lenny got that bling bling! $$$$");
                }
            }
        }



    }
}
