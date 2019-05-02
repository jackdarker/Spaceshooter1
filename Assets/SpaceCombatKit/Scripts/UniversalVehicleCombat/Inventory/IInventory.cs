using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VSX.UniversalVehicleCombat {

    public delegate void PickedUpItemHandler(Collectable Item, IInventory Collector);

    public interface IInventory {
        void AddItem(Collectable Item, int Count);
    }
}
