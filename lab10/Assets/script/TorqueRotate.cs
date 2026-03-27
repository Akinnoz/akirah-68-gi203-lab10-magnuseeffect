using UnityEngine;

public class TorqueRotate : MonoBehaviour
{
    public float torquePower = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // Exercise 1.2: หมุนแกน Z
            rb.AddTorque(new Vector3(0, 0, torquePower));
        }
    }
}