using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VSX.UniversalVehicleCombat {

    

    /// <summary>
    /// baseclass for items to be pickd up.
    /// </summary>
    public class Collectable : MonoBehaviour {
        bool o_isPickable = true;

        public bool IsConsumeOnPickup() {
            return true;
        }

        void OnTriggerEnter(Collider other) {
            //if (other.gameObject.tag.Equals("Player") ) {
                Vehicle Consumer = other.gameObject.GetComponent<Vehicle>();
                if (o_isPickable && Consumer!=null) {

                    //o_isPickable = false;
                    //renderer.material.shader = Shader.Find("Mobile/Diffuse");
                    if (IsConsumeOnPickup()) {
                        Consume(Consumer);
                    } else {

                        IInventory _inventory = other.gameObject.GetComponent<IInventory>();
                        if (_inventory != null) {
                            _inventory.AddItem(this, 1);
                        }
                    }
                //this.SetActive(false); //Todo 
                MeshRenderer meshRend = GetComponent<MeshRenderer>();
                meshRend.material.color = Color.red;
                StartCoroutine(WaitRespawn());
                }
            //}
        }
       // void Update() { }

        void Awake() {
            StartCoroutine(WaitRespawn());
        }
        IEnumerator WaitRespawn() {
            if (true){//!this.isActiveAndEnabled) {
                yield return new WaitForSeconds(5);
                MeshRenderer meshRend = GetComponent<MeshRenderer>();
                meshRend.material.color = Color.green;
            }
            yield return 0;
        }
        /// <summary>
        /// uses the Item
        /// </summary>
        public virtual void Consume(Vehicle Consumer) {

        }

        
    }
}