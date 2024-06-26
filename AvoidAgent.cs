using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;



public class AvoidAgent : MonoBehaviour

{

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("avoidcol"))
        {
            float a = GetComponent<PathfindingTester>().speed;
            GetComponent<PathfindingTester>().speed = 0f;
            yield return new WaitForSeconds(1);
            GetComponent<PathfindingTester>().speed = a;
        }
    }

  
}