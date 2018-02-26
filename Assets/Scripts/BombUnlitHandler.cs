using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombUnlitHandler : MonoBehaviour {

    public GameObject bombLit;

    void OnMouseDown()
    {
        Instantiate(bombLit, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
