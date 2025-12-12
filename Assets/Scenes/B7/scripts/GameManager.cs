using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace B7
{
    public class GameManager : MonoBehaviour
    {
        public GameObject[] Enemys;
        public Vector3 spawnValue;
        public int enemyCount;

        public float spawnWait;
        public float startWait;
        public float waveWait;

        public List<GameObject> listEnemys = new List<GameObject>();
        IEnumerator SpawnEnemy()
        {
            yield return new WaitForSeconds(spawnWait);
            while (true)
            {
                for (int i = 0; i < enemyCount; i++)
                {
                    GameObject enemy = Enemys[Random.Range(0, Enemys.Length)];
                    Vector3 spawnPosition = new Vector3(
                        Random.Range(-spawnValue.x, spawnValue.x),
                        spawnValue.y, spawnValue.z);
                    //Quaternion spwanRotation = Quaternion.identity;
                    listEnemys.Add(Instantiate(enemy, spawnPosition, enemy.transform.rotation));
                    yield return new WaitForSeconds(spawnWait);
                }
            }
        }
        void Start()
        {
            StartCoroutine(SpawnEnemy());
        }
        public int CreateItem()
        {
            int per = Random.Range(0, 100);

            if(per > itemPer[2])
            {
                return -1;
            }
            else if(per > itemPer[1])
            {
                return 2;
            }
            else if (per > itemPer[0])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public float[] itemPer = new float[3];

       
    }
}
