using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    public int speed =3;
    public float Horiz_input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horiz_input = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right *speed* Horiz_input* Time.deltaTime);

    }
}
