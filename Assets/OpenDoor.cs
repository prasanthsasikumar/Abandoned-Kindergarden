using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject openDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNow()
    {
        Debug.Log("Opening");
        this.transform.position = openDoor.transform.position;
        this.transform.rotation = openDoor.transform.rotation;
    }
}
