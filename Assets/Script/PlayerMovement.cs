using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;

        pos.x += h * Time.deltaTime * moveSpeed;
        pos.y += v * Time.deltaTime * moveSpeed;

        transform.position = pos;

        //Debug.log("");

    }
}
