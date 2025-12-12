using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B7
{
    public class Enemy2 : MonoBehaviour
    {
        public float speed;
        public float ThrowPower = 50.0f;
        private GameObject Player;
        public float hp = 1.0f;
        public float maxHp = 1.0f;
        void Start()
        {
            this.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                return;
            }
            if (other.CompareTag("Bullet"))
            {
                hp -= 1f;
                if (hp < 1.0f)
                {
                    Destroy(gameObject);
                }
                Destroy(other.gameObject);
            }
            else if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}


