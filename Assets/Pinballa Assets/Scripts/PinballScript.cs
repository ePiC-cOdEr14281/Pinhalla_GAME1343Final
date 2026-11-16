using UnityEngine;

public class PinballScript : MonoBehaviour
{
    public float maxLinearSpeed = 250;
    public float maxAngularSpeed = 100;

    Vector3 startingLocation = Vector3.zero;
    Quaternion startingRotation = Quaternion.identity;

    Rigidbody rb;

    void Start()
    {
        startingLocation = gameObject.transform.position;
        startingRotation = gameObject.transform.rotation;

        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.linearVelocity.magnitude > maxLinearSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxLinearSpeed;
        }

        if (rb.angularVelocity.magnitude > maxAngularSpeed)
        {
            rb.angularVelocity = rb.angularVelocity.normalized * maxAngularSpeed;
        }
    }

    public void Reset()
    {
        gameObject.transform.position = startingLocation;
        gameObject.transform.rotation = startingRotation;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    public void Bounce(Vector3 direction)
    {
        Vector3 bounce = direction;
        rb.AddForce(bounce);
    }
}
