using UnityEngine;
using System.Collections;

namespace VSX.UniversalVehicleCombat {

    /// <summary>
    /// Pickup that supplies Missile Ammo
    /// </summary>
    public class Pickup_MissileAmmo : Collectable {
        public override void Consume(Vehicle Consumer) {
            foreach(MountedWeapon _wpn in Consumer.Weapons.MountedWeapons) {
                if(_wpn.IsMissileModule && _wpn.IsUnitResourceConsumer) {
                    _wpn.UnitResourceConsumer.AddResourceUnits(4);
                }
            }
        }



    }
}
