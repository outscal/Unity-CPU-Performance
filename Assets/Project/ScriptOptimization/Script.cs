using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    void Update()
    {
        RotateGameObject();
    }


    public void RotateGameObject()
    {
        this.gameObject.transform.Rotate(0, 100 * Time.deltaTime, 0);

        // use a for loop as a bad wait function

        for (int i = 0; i < 1000000; i++) { }
        this.gameObject.transform.Rotate(0, 100 * Time.deltaTime, 0);
    }
}
