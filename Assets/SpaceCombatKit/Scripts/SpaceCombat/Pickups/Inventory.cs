using UnityEngine;
using System.Collections.Generic;

namespace VSX.UniversalVehicleCombat {
    /// <summary>
    /// implements the players inventory
    /// </summary>
    public class Inventory : MonoBehaviour, IInventory {

        private SortedDictionary<System.Type, int> Items = new SortedDictionary<System.Type, int>();
        public PickedUpItemHandler pickedUpItemHandler;
        /*if (pickedUpItemHandler != null)
				pickedUpItemHandler();
        this.pickedUpItemHandler += OnItemPickedUp;
        */
        public void AddItem(Collectable Item, int Count) {
            int i;
            if (Items.TryGetValue((Item.GetType()), out i)) {
                Items[Item.GetType()] = i + Count;
            } else {
                Items[Item.GetType()] = Count;
            }
        }
    }
}
