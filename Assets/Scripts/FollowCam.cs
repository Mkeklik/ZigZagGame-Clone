using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform ballLocation;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - ballLocation.position;
    }

    
    void Update()
    {
        if(BallMove.isFallBall == false)
        {
            transform.position = ballLocation.position + fark;
        }
       
    }
}
