using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labwork
{

    class Item //Item menu strop class
    {
        public const int MinHierarchyLevel = 0;
        public enum Statuses {
            VisibleAndEnabled,
            VisibleAndUnenabled,
            Invisible
        }
        public int Hierarchy {

            private set => Hierarchy = value < MinHierarchyLevel ? throw new ArgumentException("Illegal argument exception Hierarchy cannot be less than zero !!!") : value;
            get => Hierarchy;
        }
        public string Title {
            private set;
            get;
        }
        public Statuses Status {
            private set;
            get;
        }

        public string Name {
            private set;
            get;
        }

        public Item(int hierarchy, string title, Statuses status, string name) {
            this.Hierarchy = hierarchy;
            this.Title = title;
            this.Status = status;
            this.Name = name;
        }

        static Item ConvertStringToItem(string line)
        {
            var itemValues = line.Split();
            try
            {
                if (itemValues.Length == 4)

                    return new Item(System.Convert.ToInt32((itemValues[0])),
                        itemValues[1],
                        System.Convert.ToInt32((itemValues[2])) == 0
                        ? Statuses.VisibleAndEnabled : System.Convert.ToInt32((itemValues[2])) == 1
                        ? Statuses.VisibleAndUnenabled : System.Convert.ToInt32((itemValues[2])) == 2
                        ? Statuses.Invisible : throw new ArgumentException($"Unknown Status With Number : {itemValues[2]} !!!"),
                        itemValues[3]);

                if (itemValues.Length == 3)

                    return new Item(System.Convert.ToInt32((itemValues[0])),
                         itemValues[1],
                         System.Convert.ToInt32((itemValues[2])) == 0
                         ? Statuses.VisibleAndEnabled : System.Convert.ToInt32((itemValues[2])) == 1
                         ? Statuses.VisibleAndUnenabled : System.Convert.ToInt32((itemValues[2])) == 2
                         ? Statuses.Invisible : throw new ArgumentException($"Unknown Status With Number : {itemValues[2]} !!!"),
                         itemValues[3]);
                else {
                    throw new ArgumentException($"Illegal Argument : Lenght Line {line.Length} !!! Correct Lenght Line is 3 or 4");
                }
            }
            catch (Exception e) {
                throw new ArgumentException($"Line: {line} Cannot Be Convert to Item !!! Error: {e.Message}");
            }

            
        }
    }
    class MenuItems {
        
        // List items
        List<Item> items;

        public MenuItems(List<Item> items) {
            this.items = items;
        }
        private ToolStripMenuItem createStripMenuItem(int id, int Hierarchy = Item.MinHierarchyLevel) {

            if (id >= items.Count || id < 0) throw new ArgumentOutOfRangeException("Id is out Of range from List !!!");
            
            var stripMenuItem = new ToolStripMenuItem(items[id].Name);
            switch (items[id].Status)
            {
                case Item.Statuses.VisibleAndEnabled:
                    {
                        stripMenuItem.Visible = true;
                        stripMenuItem.Enabled = true;
                        break;
                    }
                case Item.Statuses.VisibleAndUnenabled:
                    {
                        stripMenuItem.Visible = true;
                        stripMenuItem.Enabled = false;
                        break;
                    }
                case Item.Statuses.Invisible:
                    {
                        stripMenuItem.Visible = false;
                        stripMenuItem.Enabled = false;
                        break;
                    }
            }
            if (items[id].Name != "") return stripMenuItem; 
            
            if (items[id].Name == "")
            {
                while (Hierarchy < items[id + 1].Hierarchy || id + 1 < items.Count) {
                    
                    if (Hierarchy + 1 == items[id + 1].Hierarchy) {
                        stripMenuItem.DropDownItems.Add(createStripMenuItem(id + 1,Hierarchy + 1));
                    }
                    
                    id++;
                }
            }
            return stripMenuItem;
        }
        public ToolStripItemCollection GetStripItems(ToolStrip toolStrip) {
            
            for(int i = 0; i< items.Count;i++) {
                if(items[i].Hierarchy == Item.MinHierarchyLevel) toolStrip.Items.Add(createStripMenuItem(i));
            }
            return toolStrip.Items;
        }
        
    }
}
