using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update, added text to the console and added movements to the asset
    void Start()
    {
        Debug.Log("whats is up home dog");
        Debug.Log("what's the deal ");
        Debug.Log("whats good gang");


        transform.Translate(0.001f, 0.001f, 0.002f);
    }

    // Update is called once per frame, added text to the console and added movements to the asset
    void Update()
    {
        Debug.Log("Burger");
        transform.Translate(0.001f, 0.001f, 0.002f);
    }
}
