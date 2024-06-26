using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class StopObject : MonoBehaviour
{
    // Start is called before the first frame update

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            float a = GetComponent<PathfindingTester>().speed;
            GetComponent<PathfindingTester>().speed = 0f;
            yield return new WaitForSeconds(1);
            GetComponent<PathfindingTester>().speed = a;
        }
    }
    private void WaitForSeconds(int v)
    {
        throw new NotImplementedException();
    }
    // Update is called once per frame

}
