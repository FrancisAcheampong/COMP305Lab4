using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

    public GameObject captFalcon;
    public Sprite firstSprite;
    public Sprite secondSprite;
    public float speed = 10.0f;

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

	// Use this for initialization
	void Start () {
        // Debug.Log(someNumber);
        rBody = captFalcon.GetComponent<Rigidbody2D>();
        sRend = captFalcon.GetComponent<SpriteRenderer>();

        rBody.velocity = new Vector2(1, 0) * speed;
	}

    // Executes when a mouse down event is fired on the attached object
    void OnMouseDown()
    {
        // Rigidbody2D rBody = captFalcon.GetComponent<Rigidbody2D>();
        rBody.velocity *= -1;

        if(sRend.sprite == firstSprite)
        {
            sRend.sprite = secondSprite;
        } else
        {
            sRend.sprite = firstSprite;
        }
        
    }
}
