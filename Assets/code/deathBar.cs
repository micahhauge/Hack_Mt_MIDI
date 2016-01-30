using UnityEngine;
using System.Collections;

public class deathBar : MonoBehaviour {

	public int lives = 300;

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
		Debug.Log("the player was hit");
		lives--;
	}
}
