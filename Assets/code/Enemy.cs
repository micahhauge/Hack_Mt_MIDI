using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;



    public class Enemy : MonoBehaviour
    {
        public int health;
        public float size;
        public int midiId; //
        public float distance;
        public GameObject instance;
		public float speed;
        public Enemy(int t, float s, GameObject i)
        {
            health = 1;
            size = s;
            midiId = t;
            distance = 100;
            instance = i;
        }
        public int getHealth(){ return health; }
        public  float getSize() { return size; }
        public int getMidiId() { return midiId; }
		public float getDistance() { return instance.transform.localPosition.y; }
		public void setHealth(int h) { health=h; }
	    public void setSize(float s) {  size=s; }
	    public void setMidiId(int m) {  midiId=m; }
	    public void setDistance(float d) {  distance=d; }
		void OnCollisionEnter(Collision other)
		{
		if(other.gameObject.name == "laser") 
		{
			health -= 1;
		}
			Debug.Log("HIT");
			Destroy(gameObject);
		}
	void Start(){
		
	}
	void Update(){
		transform.Translate(Vector3.down * Time.deltaTime * speed);
	}
}

