using UnityEngine;
using System.Collections;

public class firehaha : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject ExplosionPrefab;
    public Rigidbody projectilePrefab;


    // Use this for initialization
    void Start()
    {
        Debug.Log("Bullet Initialized");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            this.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 100);
        }
    }
}


