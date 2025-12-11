using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

namespace B7
{
    public class Bullet : MonoBehaviour
    {
        [UnityEngine.SerializeField]
        private Vector3 desttination;
        [UnityEngine.SerializeField]
        private bool isThrow = false;
        public float speed = 1.0f;

        // 방향
        public Vector3 dir;

        void Update()
        {
            if (isThrow)
            {
                // 방향계산에 따른 조준탄
                this.transform.position += dir.normalized * Time.deltaTime * speed;
            }
        }
        public void SetBullet(Vector3 _destination)
        {
            desttination = _destination;
            isThrow = true;

            // 방향 계산
            dir = desttination - this.transform.position;
        }
    }
}
