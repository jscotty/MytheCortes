using UnityEngine;
using System.Collections;

public class CubeColor : MonoBehaviour
{
    public bool Mission1;

    public GameObject[] MapPoints = new GameObject[0];

    void Update()
    {
        if (Mission1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }    
}
