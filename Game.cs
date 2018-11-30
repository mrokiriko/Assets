using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float speed_x = 0;
    public float speed_y = 0;
    public float speed = 0.1f;

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed_x = -speed;
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed_x = speed;
        } else if (Input.GetKeyDown("space"))
        {
            Vector3 jump = new Vector3(0.0f, 2.0f, 0.0f);
            GetComponent<Rigidbody2D>().AddForce(jump);
        } else if (!Input.anyKeyDown)
        {
            speed_x = 0;
            speed_y = 0;
        }

        this.transform.Translate(speed_x, speed_y, 0);




    }
}
