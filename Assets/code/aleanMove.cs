using UnityEngine;
using System.Collections;

public class aleanMove : MonoBehaviour {

	bool started = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (started == false)
		{
			started = true;
			moveStuff();
		}

	}


	void moveStuff(){
		//iTween.RotateBy(this.gameObject, iTween.Hash("x", 15, 0, iTween.EaseType.linear, iTween.LoopType.pingPong));
	}
}
