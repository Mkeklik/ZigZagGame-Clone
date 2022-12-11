using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public FloorSpawner FS;
    public static bool isFallBall;
    public float addSpeed;
    void Start()
    {
        direction = Vector3.forward;
        isFallBall = false;
    }


    void Update()
    {
        if(transform.position.y <= 0.5f)
        {
            isFallBall = true;
        }
        if(isFallBall == true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            speed += addSpeed * Time.deltaTime;
        }


    }
    private void FixedUpdate()
    {
        Vector3 movement = direction * speed * Time.deltaTime;
        transform.position += movement;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            FS.floorCreat();
            StartCoroutine(destFloor(collision.gameObject));
        }


    }
    IEnumerator destFloor(GameObject destroyingFloor)
    {
        yield return new WaitForSeconds(3f);
        Destroy(destroyingFloor);

    }
}

