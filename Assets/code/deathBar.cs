using UnityEngine;
using System.Collections;

public class deathBar : MonoBehaviour {

	public int lives = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (lives == 0)
		{
			Application.LoadLevel("gameover");
		}

	
	}

	void OnTriggerEnter(Collider coll)
	{
		Debug.Log("hit");
		lives--;
	}
}
