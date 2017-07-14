using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public string FORWARDKEY;
    public string LEFTKEY;
    public string RIGHTKEY;
    public string BACKKEY;

    public GameObject Target;

    public float moveAmount;
    public float rotationAmount;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

        checkInput();
	}

    /// <summary>
    /// Checks for input from the player
    /// </summary>
    void checkInput()
    {
        // More forward
        if (Input.GetKeyDown(FORWARDKEY))
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, moveAmount);
        }
        // More right
        if (Input.GetKeyDown(RIGHTKEY))
        {
            transform.RotateAround(Vector3.zero, Target.transform.up, -rotationAmount);
            transform.LookAt(Target.transform);
        }
        // More left
        if (Input.GetKeyDown(LEFTKEY))
        {
            transform.RotateAround(Vector3.zero, Target.transform.up, rotationAmount);
            transform.LookAt(Target.transform);
        }
        // More back
        if (Input.GetKeyDown(BACKKEY))
        {
            transform.position = Vector3.MoveTowards(transform.position, -Target.transform.position, moveAmount);
        }
    }

}
