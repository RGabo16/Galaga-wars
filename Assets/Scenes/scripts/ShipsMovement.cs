using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "limite")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            speed *= -1;
        }
    }
}
