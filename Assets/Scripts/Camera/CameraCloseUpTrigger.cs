using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloseUpTrigger : MonoBehaviour {

    public Transform p_Position;
    public Rigidbody2D rBody;

    public Camera mainCamera;
    public Camera closeUpCamera;

    public float max =35, min = 5;

    // Defined by unity
    void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is a player, then do something
        if(other.gameObject.tag == "Player")
        {
            mainCamera.enabled = false;
            closeUpCamera.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            closeUpCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            closeUpCamera.transform.LookAt(p_Position);
            max = 34;
            min = 7;
            if (rBody.velocity.x < 0) //zoom out
            {
                closeUpCamera.fieldOfView++;
                if (closeUpCamera.fieldOfView > max)
                {
                    closeUpCamera.fieldOfView = max;
                }
            }
            if (rBody.velocity.x > 0) //zoom in
            {
                closeUpCamera.fieldOfView--;
                if (closeUpCamera.fieldOfView < min)
                {
                    closeUpCamera.fieldOfView = min;
                }
            }
        }
    }

}
