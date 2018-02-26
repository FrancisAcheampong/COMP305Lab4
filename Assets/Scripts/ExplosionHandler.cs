using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionHandler : MonoBehaviour {

    public GameObject plusOne;

    void Explode()
    {
        Instantiate(plusOne, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
