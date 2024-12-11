using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePuzzle : MonoBehaviour
{
    private bool cylinderCollided = false;
    private bool sphereCollided = false;

    public Material redColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(cylinderCollided && sphereCollided)
        {
            Debug.Log("Puzzle Complete");
            this.GetComponent<MeshRenderer>().material = redColor;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cylinder")
        {
            cylinderCollided = true;
            Debug.Log("Cylinder collided");
        } else if (other.name == "Sphere")
        {
            sphereCollided = true;
            Debug.Log("Sphere collided");
        }
    }
}
