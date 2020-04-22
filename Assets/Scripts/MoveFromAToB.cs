using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromAToB : MonoBehaviour
{
    public Transform left;
    public Transform right;
    public float speed;

    private float nextX;

    private void UpdateNextX()
    {
        if(Mathf.Abs(transform.position.x - left.position.x) < Mathf.Abs(transform.position.x - right.position.x))
        {
            nextX = right.position.x;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            nextX = left.position.x;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    
    void Start()
    {
        UpdateNextX();
    }

    void Update()
    {
        if (Mathf.Abs(transform.position.x - nextX) < 1.0f)
        {
            UpdateNextX();
        }
        Vector3 newPos = new Vector3(nextX, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * speed);
    }
}