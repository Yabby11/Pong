using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public Rigidbody Paddle;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.UpArrow)) {
						
			rigidbody.AddForce(0, 10, 0);	
				}

		if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody.AddForce(0, -10, 0);
				}



}
}
