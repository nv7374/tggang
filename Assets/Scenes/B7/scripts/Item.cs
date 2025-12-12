using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B7
{
    [System.Serializable]
    public enum ItemStatus
    {
        hp,
        upgrade,
        bomb
    }
    public class Item : MonoBehaviour
    {
        public float itemSpeed = -0.25f;

        public ItemStatus status = ItemStatus.hp;
        void Update()
        {
            this.transform.position = new Vector3(this.transform.position.x,
                this.transform.position.y,
                this.transform.position.z + Time.deltaTime * itemSpeed);
        }
    }
}
