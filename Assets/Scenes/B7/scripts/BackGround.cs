using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B7
{
    public class BackGround : MonoBehaviour
    {
        public float mapSpeed;
        public float mapSizeZ;

        private Vector3 StartPos;
        // Start is called before the first frame update
        void Start()
        {
            StartPos = this.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            float newPosition = Mathf.Repeat(this.transform.position.z + Time.deltaTime * mapSpeed, mapSizeZ);
            transform.position = new Vector3(StartPos.x, StartPos.y, newPosition);
        
        }
    }
}
