using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour
{
	public float smooth = 3f;		// a public variable to adjust smoothing of camera motion
	Transform standard_pos;			// the usual position for the camera, specified by a transform in the game
	Transform look_at_pos;			// the position to move the camera to when using head look
	
	void Start()
	{
		// initialising references
		standard_pos = GameObject.Find ("CamPos").transform;
		
		if(GameObject.Find("LookAtPos"))
		{
			look_at_pos = GameObject.Find("LookAtPos").transform;
		}			
	}
	
	void FixedUpdate ()
	{
		// if we hold Alt
		if(Input.GetButton("Fire2") && look_at_pos)
		{
			// lerp the camera position to the look at position, and lerp its forward direction to match 
			transform.position = Vector3.Lerp(transform.position, look_at_pos.position, Time.deltaTime * smooth);
			transform.forward = Vector3.Lerp(transform.forward, look_at_pos.forward, Time.deltaTime * smooth);
		}
		else
		{	
			// return the camera to standard position and direction
			transform.position = Vector3.Lerp(transform.position, standard_pos.position, Time.deltaTime * smooth);	
			transform.forward = Vector3.Lerp(transform.forward, standard_pos.forward, Time.deltaTime * smooth);
		}
		
	}
}
