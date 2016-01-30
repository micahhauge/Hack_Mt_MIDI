using UnityEngine;
using System.Collections;

public class spawnPoint : MonoBehaviour {

	public GameObject laser;
	public int key;
	public string keyboardKey;
	private bool beamOn = false;

	private GameObject clone;
	public Overseer EnemyList;
	// Use this for initialization
	void Start () {
		EnemyList = GameObject.Find("Overseer").GetComponent<Overseer>();
	}
	
	// Update is called once per frame
	void Update () {

		if( (beamOn == false) && (MidiJack.MidiMaster.GetKey(0,key) > 0))
		{
			beamOn = true;
			clone = Instantiate(laser, transform.position, Quaternion.identity) as GameObject;
			EnemyList.recieveAttack(key);
		}

		if( (beamOn == true) && (MidiJack.MidiMaster.GetKey(0,key)==0))
		{
			beamOn = false;
			Destroy(clone);
		}
		/*
		if ((MidiJack.MidiMaster.GetKeyDown(key) || Input.GetKeyDown(keyboardKey)) && beamOn == false)
		{
			Debug.Log("Key Pressed");
			beamOn = true;

			clone = Instantiate(laser, transform.position, Quaternion.identity) as GameObject;
		}

		if ((MidiJack.MidiMaster.GetKeyUp(key) || Input.GetKeyUp(keyboardKey)) && beamOn == true)
		{
			beamOn = false;
			Destroy(clone);
		}
*/
	}
}
