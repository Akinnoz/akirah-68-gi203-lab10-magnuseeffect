using UnityEngine;

public class AngularVelocity : MonoBehaviour
{
    public float angularSpeed = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // หมุนทันที
            rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
        else
        {
            // Exercise 1.1: ปล่อยปุ่มแล้วหยุดทันที
            rb.angularVelocity = Vector3.zero;
        }
    }
}