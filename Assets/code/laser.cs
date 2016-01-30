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
		if (hasImpacted == false && transform.localScale.y < 40)
		{
			transform.localScale += new Vector3(0, speed, 0);
		}
		else if( hasImpacted == false )
		{
			// subtract from shield energy or something??
		}
		else {
			//transform.localScale -= new Vector3(0, speed, 0);
			//Destroy(gameObject);
			transform.localScale += new Vector3((float)0.0, (float)-0.1,(float)0.0);
			hasImpacted = true;
		}
	//	if(transform.localScale.y > 100)
	//	{
	//		Destroy(gameObject);
	//	}
	}

	void OnTriggerEnter(Collider other) {

		hasImpacted = true;
        if (other.attachedRigidbody)
        {	
			//DO DAMAGE TO NOTE
            //other.attachedRigidbody.useGravity = true;
			//iTween.RotateBy(other.gameObject, new Vector3(12, 2, 4), 30f);
			// works, but does not account for HP

        }

        
    }
}
