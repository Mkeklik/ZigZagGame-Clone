using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject lastFloor;
    

    
    void Start()
    {
        for(int i = 0; i < 11;)
        {
            floorCreat();
            i++;
        }
    }

    public void floorCreat()

    {
        Vector3 yon;
        if(Random.Range(0,2) == 0)
        {
            yon = Vector3.left;
        }
        else
        {
            yon = Vector3.forward;
        }
        lastFloor = Instantiate(lastFloor, lastFloor.transform.position + yon, lastFloor.transform.rotation);
    }


}
