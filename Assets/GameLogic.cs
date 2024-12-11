using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour
{
    public bool ballComplted = false, gunCompleted = false, bookCompleted = false;
    public UnityEvent finished, spideyJump;
    bool completed = false;
    public GameObject spidey;

    private bool spiderGrabbed = false;

    private bool jumpInProgress = false;
    private GameObject head;

    //public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        head = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (!completed && ballComplted && bookCompleted && gunCompleted)
        {
            Debug.Log("Door opens");
            finished.Invoke();
            completed = true;
        }
        if (jumpInProgress && !spiderGrabbed)
        {
            spidey.transform.position = Vector3.Lerp(spidey.transform.position, head.transform.position, 0.1f);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.name == "GoldenBall")
        {
            ballComplted = true;
            CallSpidey();
        } else if (collision.collider.gameObject.name == "BubbleGun_main")
        {
            gunCompleted = true;
        } else if (collision.collider.gameObject.name == "Book_main")
        {
            bookCompleted = true;
        }
    }

    public void CallSpidey()
    {
        spidey.SetActive(true);
        jumpInProgress = true;
        spideyJump.Invoke();
    }

    public void grabbed()
    {
        spiderGrabbed = true;
    }
}
