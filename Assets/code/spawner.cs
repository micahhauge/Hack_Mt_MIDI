using System;
using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawner : MonoBehaviour {

	public string levelname = "luke.txt";
	public double time;
	public int note;
	public float Duration;
	public double timer;
	public float textSpeed;
	public GameObject text;
	public float healthMul;
	public bool gameStarted = false;


	private System.IO.StreamReader file;
	private string line;
	public GameObject noteObject;
	
	private int length;
    public int counter = 0;
    deathBar reference;

    public Overseer EnemyList;

    // Use this for initialization
    void Start () {
		


        EnemyList = GameObject.Find("Overseer").GetComponent<Overseer>();
        //int counter = 0;
        //int size=Int32.Parse(file.ReaTdLine());
        //timer=0;
        //UnityEngine.Debug.Log(line);
        //while ((line = file.ReadLine()) != null)
        //{
        //	string[] row=line.Split(' ');
        // 	note=Int32.Parse(row[1]);
        //	time=float.Parse(row[0]);

        //StartCoroutine(coroutine(time));// start spin lock
        //Debug.Log(timer);

        //noteFall clonescript = clone.GetComponent<noteFall>();
        //note to change this to Int32.Parse at some time
        //clonescript.setTimeOffset(float.Parse(row[0]));
        //clone.GetComponent<noteFall>().timeOffset=float.Parse(row[0]);

        //clone.GetComponent<noteFall>().setTimeOffset(float.Parse(row[0]));
        //Debug.Log(float.Parse(row[0]));
        // }
        // file.Close();  

        //reference = GameObject.Find("DeathBox").GetComponent<deathBar>();
    }
	public IEnumerator coroutine(double t) {
		
		yield return new WaitForSeconds((int)t); // NOOOOOOOOOO DUMB DUMB

	}
	public void setFile(string levelname, string levelDisplay){
		file = new System.IO.StreamReader(Application.dataPath +"/gen_level/"+ levelname);
		gameStarted = true;
		Debug.Log("Game Started");
		length = Int32.Parse(file.ReadLine());
		line = file.ReadLine();
		GameObject myText = Instantiate(text, new Vector3(-18, 52, 1), this.transform.rotation) as GameObject;
		TextMesh tm = myText.GetComponent<TextMesh>();
		tm.text = levelDisplay;
		iTween.MoveBy(myText, new Vector3(0f, -100, 0f), 50f);
	}
	// Update is called once per frame
	void Update () 
	{
		if (gameStarted == true)
		{
			if(length>0)
			{
			timer = timer + Time.deltaTime;
			string[] row = line.Split(' ');

			if (float.Parse(row[0]) < timer)
			{
					//Debug.Log(row[1]);
	            	//If it's time to spawn a new note, do so
					GameObject tmp = Instantiate(noteObject, GameObject.Find(row[1]).transform.position, Quaternion.identity) as GameObject;
	            	note = Int32.Parse(row[1]);
	            	Enemy E = tmp.GetComponent<Enemy>();
	        	    E.midiId = note;
	    	        E.health = healthMul * float.Parse(row[2]);
		            E.size = float.Parse(row[2]);
					//tmp.transform.Translate(Vector3.right * (note - 59));

	            	EnemyList.Add(E);
						
	            	counter++;
	            	
					//And read the next line
			    	line = file.ReadLine();
					length--;
				}
			}
		}

	}
	public double getTime(){
		return timer;
	}

}
