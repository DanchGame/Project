using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float MoveSpeed = 1.5f;
    float RotateSpeed = 60;
    float CurrentSpeed = 0;
    int SpeedNum = 0;
    Rigidbody TankEngane;
    public float speed = 10;
    public float speed_2 = 60;
    public static float vertical, horizontal;
    public GameObject Tower;

    void Rotaiter()
    {
        float AngleRotate = Time.deltaTime * speed_2 * Input.GetAxis("Mouse X");
        Tower.transform.Rotate(0, AngleRotate, 0);
    }

    void FixedUpdate()
    {
       Rotaiter();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * speed_2 * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}