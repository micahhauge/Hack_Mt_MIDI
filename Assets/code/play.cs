using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

	public GameObject camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Debug.Log("PLAY");
		iTween.RotateBy(camera, iTween.Hash("x", -0.25f, 300, 0f, "easetype", iTween.EaseType.easeInOutQuint));
	}
}
