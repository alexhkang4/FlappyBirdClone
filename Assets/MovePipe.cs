using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour {

    public float speed = 0.4f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if ()
    }

    public void Stop() {
        transform.position = transform.position;
    }
}
