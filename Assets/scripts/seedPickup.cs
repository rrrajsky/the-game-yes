using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class seedPickup : MonoBehaviour
{

    public TextMeshProUGUI text;
    public TopDownMovement player;

    void Start()
    {
        text.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bunny"))
        {
            text.enabled = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(gameObject);
            text.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("bunny"))
        {
            text.enabled = false;
        }
    }
}
