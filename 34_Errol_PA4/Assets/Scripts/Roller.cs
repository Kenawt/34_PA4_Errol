using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    float RollSpeed = 20;
    Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float InputHori = Input.GetAxis("Horizontal");
        float InputVert = Input.GetAxis("Vertical");

        Vector3 Motion = new Vector3(InputHori, 0, InputVert);

        ball.AddForce(Motion * RollSpeed * Time.deltaTime);
    }
}
