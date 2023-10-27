using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Destroy Circle")
        {
            Destroy(other.gameObject, 0.5f);
            Debug.Log("Object destroyed");
        }
    }

}
