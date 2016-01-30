using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LiveText: MonoBehaviour
{

    deathBar reference;
    int lives ;
     Text text;
    // Use this for initialization
    void Start()
    {
        reference = GameObject.Find("DeathBox").GetComponent<deathBar>();
        lives = reference.lives;
        text = GetComponent<Text>();
        text.text = "Lives : " + lives;
        Debug.Log(text.text);
        
    }

    // Update is called once per frame
    void Update()
    {
        lives = reference.lives;
        text.text = "Lives : " + lives;


    }

}
