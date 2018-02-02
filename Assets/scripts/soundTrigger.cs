using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTrigger : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D hit)
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
