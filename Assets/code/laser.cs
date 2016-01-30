using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {

	public float speed;
	private bool hasImpacted = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hasImpacted == false)
		{
			transform.localScale += new Vector3(0, speed, 0);
		}
	}

	void OnTriggerEnter(Collider other) {

		hasImpacted = true;

        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.useGravity = true;
        }

        
    }
}
