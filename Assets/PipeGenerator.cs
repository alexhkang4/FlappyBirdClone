using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {

    public float maxTime = 1.5f;
    private float timer = 0;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start() {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(- 0.4f, 0.4f), 0);
        Destroy(newPipe, 10);
    }

    // Update is called once per frame
    void Update() {
        if (timer > maxTime) {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(- 0.4f, 0.4f), 0);
            Destroy(newPipe, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
