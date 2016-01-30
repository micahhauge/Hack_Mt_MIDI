using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deathBar : MonoBehaviour {

	public int lives = 50;
    //Text text;
	// Use this for initialization
	void Start () {
        //text = GetComponent<Text>();
        //text.text = "Lives : " + lives;
       // Debug.Log(text.text);
    }
	
	// Update is called once per frame
	void Update () {
        //text.text = "Lives : " + lives;
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
