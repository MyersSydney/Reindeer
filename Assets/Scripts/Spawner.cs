using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTimer = 1;
    private float timer = 0;
    public GameObject[] pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe[UnityEngine.Random.Range(0, 11)]);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
      if(timer > maxTimer)
        {
            GameObject newPipe = Instantiate(pipe[UnityEngine.Random.Range(0, 11)]);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
