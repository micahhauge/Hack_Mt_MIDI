using UnityEngine;
using System.Collections;

public class loadLevel : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;
	public string stringlevel;
	public string levelDisplay;
	public GameObject spawner;

	// Use this for initialization
	void Start () {
		camera1.GetComponent<Camera>().enabled = true;
		camera2.GetComponent<Camera>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		camera1.GetComponent<Camera>().enabled = false;
		camera2.GetComponent<Camera>().enabled = true;
		iTween.RotateBy(camera2, iTween.Hash("x", -0.31f, 5, iTween.EaseType.easeInOutQuint));
		spawner mySpawner = spawner.GetComponent<spawner>();
		mySpawner.setFile(stringlevel, levelDisplay);
	}


}
