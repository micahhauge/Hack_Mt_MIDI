using UnityEngine;
using System.Collections;

public class noteFall : MonoBehaviour {

	public float speed;
	public float timeOffset;
	public float health;
	public spawner spawn;
	public GameObject spawnerObj;
	public void setTimeOffset(float to){
		//timeOffset=to;
	}

	// Use this for initialization
	void Start () {
		//timeOffset=0;
		//spawn = spawnerObj.GetComponent<spawner>();
		health=1;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(timeOffset);
		//if (timeOffset >= spawn.getTime())
		//{
			transform.Translate(Vector3.down * Time.deltaTime * speed);
		//}
		if(health == 0) {
			Destroy(gameObject);
		}
	}


	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "laser") 
		{
			health -= 1;
		}
		Debug.Log("HIT");
		Destroy(gameObject);
	}
}
