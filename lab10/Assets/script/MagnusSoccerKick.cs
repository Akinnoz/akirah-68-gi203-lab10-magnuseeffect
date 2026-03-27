using UnityEngine;

public class MagnusSoccerKick : MonoBehaviour
{
    public float kickForce = 30f;
    public float spinForce = 10f;
    public float magnusStrength = 4f;

    Rigidbody rb;
    bool kicked = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !kicked)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            rb.AddForce(Vector3.right * kickForce, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * spinForce, ForceMode.Impulse);

            kicked = true;
        }
    }

    void FixedUpdate()
    {
        if (kicked)
        {
            Vector3 magnus = Vector3.Cross(rb.angularVelocity, rb.velocity) * magnusStrength;
            rb.AddForce(magnus);
        }
    }
}