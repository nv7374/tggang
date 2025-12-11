using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B7
{
    public class Player : MonoBehaviour
    {
        // 총알 딜레이
        public float bulletTime = 0.1f;
        // 총알 딜레이만큼 시간이 지나갔는지 체크
        public float reloadTime = 0f;
        Rigidbody thisRigi;
        // 플레이어의 이동속도
        public float speed = 2.0f;
        // 총알 프리팹
        public GameObject ObjBullet;
        // 총알이 생성될 위치
        public Transform BulletPoint;

        public float hp = 1.0f;

        void Start()
        {
            thisRigi = this.GetComponent<Rigidbody>();
        }
        private void Move()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(moveX, 0f, moveZ);
            thisRigi.velocity = move * speed;

            Vector3 posInWorld = Camera.main.WorldToScreenPoint(this.transform.position);
            float posX = Mathf.Clamp(posInWorld.x, 0, Screen.width);
            float posZ = Mathf.Clamp(posInWorld.y, 0, Screen.height);

            Vector3 posInScreen = Camera.main.ScreenToWorldPoint(new Vector3(posX, posZ, 0));

            thisRigi.position = new Vector3(posInScreen.x, 0, posInScreen.z);

        }
        void Update()
        {
            Move();
            FireBullet();
        }
        void FireBullet()
        {
            reloadTime += Time.deltaTime;

            if (Input.GetButton("Fire1") && (bulletTime <= reloadTime))
            {
                reloadTime = 0f;
                GameObject bullet = Instantiate(ObjBullet, BulletPoint.position, this.transform.rotation);
                bullet.GetComponent<Bullet>().SetBullet(BulletPoint.position + Vector3.forward);
            }
        }
        void OnTriggerEnter(Collider other)
        {
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
                hp -= 1f;
            }
        }
    }
}
