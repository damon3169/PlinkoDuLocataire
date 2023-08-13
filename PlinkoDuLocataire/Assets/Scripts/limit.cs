using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class limit : MonoBehaviour
{
    [SerializeField]
    private BallManager ballManager;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball")
        {
            ballManager.removeBall();
            Destroy(collision.gameObject);
        }
    }
}

