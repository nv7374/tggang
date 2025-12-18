using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B7
{
    public class GameDataManager : Singleton<GameDataManager>
    {
        public float gameTime = 0;
        public int gameScore;
        public string curld;

        public int Bomb = 0;
        public int maxBomb = 0;
        public float bombTime = 2.0f;
        public float bombing = 0f;
        public bool isBomb = false;
        public float NoBombSpeed = 1.0f;

        public float fixTime = 60.0f;
        public float fixing = 0f;
        public bool isFix = false;
        public float NoFixSpeed = 1.0f;

        public float hp = 10f;
        public float maxHp = 10;
        public int upgrade = 0;
        public int maxUpgrade = 3;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
