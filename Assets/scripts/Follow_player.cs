using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_player : MonoBehaviour
{

    public Transform player;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(5,6,-4);
        
    }
}
