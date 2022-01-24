using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollectable : MonoBehaviour
{

    public List<GameObject> obstacles = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            //obstacles[i].tag = "Obstacle";
            transform.GetChild(i).tag = "Obstacle";
            //transform.GetChild(i).gameObject.AddComponent<ObstacleHit>();
            transform.GetChild(i).gameObject.AddComponent<BoxCollider>();
            transform.GetChild(i).gameObject.AddComponent<Rigidbody>();
            transform.GetChild(i).gameObject.GetComponent<Rigidbody>().mass=10;
            transform.GetChild(i).gameObject.GetComponent<Rigidbody>().drag=1;
            transform.GetChild(i).gameObject.GetComponent<Rigidbody>().angularDrag=1;


        }
    }

   
}
