using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowWithBuffer : MonoBehaviour {

    public Transform playerPosition;
    public Transform playerMoveThreshold;

	// Use this for initialization
	void Start () {
        playerMoveThreshold = transform.GetChild(0);
	}
	
	// Update is called once per framet\
	void Update () {
		if(playerPosition.position.x > playerMoveThreshold.position.x)
        {
            this.transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
        }
	}

    // Predefined Unity function for drawing Gizmos in the editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(playerMoveThreshold.position, new Vector3(playerMoveThreshold.position.x, playerMoveThreshold.position.y + 100, playerMoveThreshold.position.z));
        Gizmos.DrawLine(playerMoveThreshold.position, new Vector3(playerMoveThreshold.position.x, playerMoveThreshold.position.y - 100, playerMoveThreshold.position.z));
    }
}
