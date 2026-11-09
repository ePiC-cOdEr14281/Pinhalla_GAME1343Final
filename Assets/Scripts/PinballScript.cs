using UnityEngine;

public class PinballScript : MonoBehaviour
{
    Vector3 startingLocation = Vector3.zero;

    Quaternion startingRotation = Quaternion.identity;

    Rigidbody rb;

    void Start()
    {
        startingLocation = gameObject.transform.position;
        startingRotation = gameObject.transform.rotation;

        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void Reset()
    {
        gameObject.transform.position = startingLocation;
        gameObject.transform.rotation = startingRotation;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
