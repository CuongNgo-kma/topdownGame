using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float life=3;

    private void Awake() {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other) {
        // Destroy(other.gameObject);
        // Destroy(gameObject);
    }
}
