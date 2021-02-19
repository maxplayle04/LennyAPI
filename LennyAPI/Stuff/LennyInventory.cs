using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LennyAPI.Stuff
{
    public class LennyInventory
    {

        private static List<LennyItem> Contents = new List<LennyItem>();

        public void AddItem(LennyItem item)
        {
            if (Contents.Where(x => x.Name == item.Name).Count() > 0)
            {
                foreach (var invenItem in Contents)
                {
                    if (invenItem.Name == item.Name)
                    {
                        invenItem.Quantity++;
                        return;
                    }
                }
                Contents.Add(item);
            }
        }

        public void RemoveItem(LennyItem item)
        {
            bool shouldRemove = false;
            if (Contents.Where(x => x.Name == item.Name).Count() > 0)
            {
                foreach (var invenItem in Contents)
                {
                    if (invenItem.Name == item.Name)
                    {
                        if (invenItem.Quantity > 1)
                        {
                            invenItem.Quantity--;
                        }
                        else
                        {
                            shouldRemove = true;
                        }
                    }
                }
            }

            if (shouldRemove)
            {
                Contents.Remove(item);
            }
        }

        public bool HasItem(LennyItem item)
        {
            return Contents.Where(i => i.Name == item.Name && i.IsExpensive == item.IsExpensive && i.IsDirty == item.IsDirty).Count() > 0;
        }

        public LennyItem[] GetItems()
        {
            return Contents.ToArray();
        }
    }
}
