using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class plotScript : MonoBehaviour
{

    public int size;
    private int seed;
    public Mesh newMesh;

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            seed = 1;
            ChangeModel();
            Debug.Log("this should change something");
            
        }
    }

    public void ChangeModel()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        if (meshFilter != null && newMesh != null)
        {
            meshFilter.mesh = newMesh;
            Debug.Log("Model changed successfully!");
        }
        else
        {
            Debug.LogError("MeshFilter or newMesh is not assigned!");
        }
    }

}

