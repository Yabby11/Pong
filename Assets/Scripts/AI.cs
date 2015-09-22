using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public float PuckY;
	public Vector3 puckPos;
	public GameObject puck;
	public float x;
	public float z;
	public float MaxSpeed;
	// Use this for initialization
	void Start () {
	
		puck = GameObject.Find ("Puck");
		x = this.transform.position.x;
		z = this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
	
		PuckY = puck.transform.position.y;
		puckPos = new Vector3 (x, PuckY, z);
		this.transform.position = puckPos;


	}
}
