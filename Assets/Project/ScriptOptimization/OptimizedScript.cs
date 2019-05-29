using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizedScript : MonoBehaviour
{
    void Update()
    {
        RotateGameObject();
    }

    public void RotateGameObject()
    {
        this.gameObject.transform.Rotate(0, 100 * Time.deltaTime, 0);
        StartCoroutine(WaitRotate());
    }

    private IEnumerator WaitRotate()
    {
        yield return new WaitForSeconds(10);
        this.gameObject.transform.Rotate(0, 100 * Time.deltaTime, 0);
    }
}
