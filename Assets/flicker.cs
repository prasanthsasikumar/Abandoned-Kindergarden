using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    public GameObject[] lights;
    public int[] counts;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < counts.Length; i++)
        {

            if (lights[i].gameObject.activeSelf)
            {
                if (counts[i] <= 0)
                {
                    lights[i].gameObject.SetActive(false);
                    counts[i] = Random.RandomRange(10, 300);
                }
            }
            else
            {
                if (counts[i] <= 0)
                {
                    lights[i].gameObject.SetActive(true);
                    counts[i] = Random.RandomRange(10, 800);
                }
            }
            counts[i]--;
        }
    }
}
