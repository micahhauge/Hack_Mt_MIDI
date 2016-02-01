using UnityEngine;
using System.Collections;

public class spawnPoint : MonoBehaviour {

	public GameObject laser;
	public int key;
	private bool beamOn = false;
    private Overseer EnemyList;
	private GameObject clone;

	// Use this for initialization
	void Start () {
        EnemyList = GameObject.Find("Overseer").GetComponent<Overseer>();
    }
	
	// Update is called once per frame
	void Update () {
		if (MidiJack.MidiMaster.GetKey(0,key)> 0 && beamOn == false) 
		{
			//Debug.Log("Key Pressed");
			//Debug.Log(key);
			beamOn = true;

			clone = Instantiate(laser, transform.position, Quaternion.identity) as GameObject;
            EnemyList.recieveAttack(key);

		}
        if(MidiJack.MidiMaster.GetKey(0,key)==0 && beamOn == true)
        {
            beamOn = false;
            Destroy(clone);
        }
			
    }
}
