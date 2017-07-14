using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantHead : MonoBehaviour {


    public enum DIRECTION { CounterClockwise, Clockwise };
    public DIRECTION direction;

    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotateHead();	
	}
    
    /// <summary>
    /// Rotates the elephants head according to rotation direction
    /// </summary>
    public void rotateHead()
    {
        switch (direction)
        {
            case DIRECTION.CounterClockwise:
                transform.RotateAround(Vector3.zero,transform.up, -rotationSpeed*Time.deltaTime);
                break;
            case DIRECTION.Clockwise:
                transform.RotateAround(Vector3.zero, transform.up, rotationSpeed * Time.deltaTime);
                break;
        }
        
    }

}
