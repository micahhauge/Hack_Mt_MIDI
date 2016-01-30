using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class noteFall : MonoBehaviour {

	public float speed;
	public float timeOffset;
	public spawner spawn;
	public GameObject spawnerObj;
    
	public void setTimeOffset(float to){
		//timeOffset=to;
	}

	// Use this for initialization
	void Start () {
		//timeOffset=0;
		//spawn = spawnerObj.GetComponent<spawner>();
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(timeOffset);
		//if (timeOffset >= spawn.getTime())
		//{
			transform.Translate(Vector3.down * Time.deltaTime * speed);
		//}
		 	
	}


	void OnTriggerEnter(Collider other)
	{
			
	}
}
