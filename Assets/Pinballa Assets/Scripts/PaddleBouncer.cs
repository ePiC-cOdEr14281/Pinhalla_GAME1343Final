using UnityEngine;

public class PaddleBouncer : MonoBehaviour
{

    public GameObject flipperControl;

    private FlipperScript fs;

    public float bouncePower = 500;

    void Start()
    {
        fs = flipperControl.GetComponent<FlipperScript>();
    }


    void OnTriggerEnter(Collider other) //Idk yet
    {
        PinballScript pb = other.gameObject.GetComponent<PinballScript>();
        if (!pb)
        {
            return;
        }

        if (fs.left)
        {
            Vector3 direction = other.gameObject.transform.position - gameObject.transform.position;
            pb.Bounce(bouncePower * Vector3.forward + direction.normalized);
        }
        if (fs.right)
        {
            Vector3 direction = other.gameObject.transform.position - gameObject.transform.position;
            pb.Bounce(bouncePower * Vector3.forward + direction.normalized);
        }
    }
}
