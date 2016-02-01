using UnityEngine;
using System.Collections;

public class textInto : MonoBehaviour {

	private int timer;
	public int waitTime;
	private bool gone = false;
	public GameObject startText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer++;

		if(timer > waitTime && gone == false)
		{
			Destroy(startText);
			iTween.MoveBy(this.gameObject, new Vector3(0, 0, 50), 1f);
			gone = true;
			waitTime = 0;
		}

	}
}
