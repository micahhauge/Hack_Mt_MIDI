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
        public int distance;
        public GameObject instance;

        public Enemy(int t, int s, GameObject i)
        {
            health = 999;
            size = s;
            midiId = t;
            distance = 100;
            instance = i;
        }
        public int getHealth(){ return health; }
        public  int getSize() { return size; }
        public int getMidiId() { return midiId; }
        public int getDistance() { return distance; }
    public void setHealth(int h) { health=h; }
    public void setSize(int s) {  size=s; }
    public void setMidiId(int m) {  midiId=m; }
    public void setDistance(int d) {  distance=d; }
}

