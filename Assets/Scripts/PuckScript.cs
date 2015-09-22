using UnityEngine;
using System.Collections;

public class PuckScript : MonoBehaviour {
public Rigidbody rigidbody;
	public bool travelLeft;
	// Use this for initialization
	void Start () {
		rigidbody.AddForce (-100, 0, 0);
		travelLeft = true; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision Other)
	{

		Debug.Log ("Hit");
		if (travelLeft == true) 
		{
		    rigidbody.AddForce (100, 0, 0);
			travelLeft = false;
		} 

		else 
		{
			rigidbody.AddForce (-100, 0, 0);
			travelLeft = true; 
		}
	}
}
