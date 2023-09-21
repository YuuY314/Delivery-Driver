using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Encostou em algo");
    }

    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Passou em algo");
    }
}
