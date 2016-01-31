using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;



    public class Enemy : MonoBehaviour
    {
        public float health;   // hits (duration) of note
        public float size;     // length of spawned object
        public int midiId;   // int key code
    public float speed; //the speed of the key
        //public float distance;  // available in position
        public GameObject instance;

        public Enemy(int id, float siz, GameObject i)
        {
            health = 1000000 * siz;  // based on row[2] data
            size = siz;
            midiId = id;
            //distance = 100.0f;
            instance = i;
        }
        public void destroy()
    {
        gameObject.transform.GetComponent<Rigidbody>().useGravity = true;
    }
        public void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
        public float getHealth(){ return health; }
        public float getSize() { return size; }
        public int getMidiId() { return midiId; }
        //public int getDistance() { return distance; }
        public void setHealth(float h) { health=h; }
        public void setSize(float s) {  size=s; }
        public void setMidiId(int id) {  midiId=id; }
        //public void setDistance(int d) {  distance=d; }
}

