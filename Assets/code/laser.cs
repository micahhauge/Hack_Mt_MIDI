using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {

	public float speed;
	private bool hasImpacted = false;
    ScoresText st;
    public Overseer EnemyList;
    // Use this for initialization
    void Start () {
	st= GameObject.Find("ScoreBoard").GetComponent<ScoresText>();
    EnemyList = GameObject.Find("Overseer").GetComponent<Overseer>();
    }
	
	// Update is called once per frame
	void Update () {
		if (hasImpacted == false)
		{
			transform.localScale += new Vector3(0, speed, 0);
		}
	}


}
