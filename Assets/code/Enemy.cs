using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;



    public class Enemy : MonoBehaviour
    {
        public int health;
        public int size;
        public int midiId; //
        public int distFromPlayer; 
        public Enemy(int t, int s)
        {
            health = s;
            size = s;
            midiId = t;
            distFromPlayer = 100;
        }
    }

