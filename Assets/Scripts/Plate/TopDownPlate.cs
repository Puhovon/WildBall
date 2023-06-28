using System;
using UnityEngine;

public class TopDownPlate : MonoBehaviour
{
    public bool canMove;
    [SerializeField, Range(0, 10)] private int speed;
    [SerializeField] private int startPoint;
    [SerializeField] private Transform[] points;

    private int i;
    private bool reverse;

    private void Awake()
    {
        transform.position = points[startPoint].position;
        i = startPoint;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, points[i].position) < 0.01f)
        {
            canMove = false;
            if (i == points.Length -1)
            {
                reverse = true;
                i--;
                return;
            } else if (i == 0)
            {
                reverse = true;
                i++;
                return;
            }

            if (reverse)
            {
                i--;
            }
            else
            {
                i++;
            }
        }
        
        if (canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            canMove = true;
    }
    
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
            canMove = false;
    }
}
