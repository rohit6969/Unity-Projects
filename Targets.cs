﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public GameObject myPrefab = null;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //Instantiate(myPrefab, transform.position, Quaternion.identity);

    }


}