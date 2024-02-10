using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
        public static LevelManager Main;

        public Transform startPoint;
        public Transform[] path;
    
        private void Awake()
        {
            Main = this; 
         }
}
