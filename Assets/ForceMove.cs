using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMove : MonoBehaviour
{
    bool jumped;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        jumped = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //left direction
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left);
        }

        //right direction
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right);
        }

        //up direction
        if (Input.GetKeyDown(KeyCode.Space) && jumped == false)
        {
            rb.AddForce(Vector2.up * 450f);
            jumped = true;
            StartCoroutine(jumpRefresh());
        }
    }

    public IEnumerator jumpRefresh()
    {
        yield return new WaitForSeconds(2f);
        jumped = false;
    }
}
