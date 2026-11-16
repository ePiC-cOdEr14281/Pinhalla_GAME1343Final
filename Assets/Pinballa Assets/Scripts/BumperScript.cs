using UnityEngine;

public class BumperScript : MonoBehaviour
{
    public float bouncePower = 1000;

    private void OnTriggerEnter(Collider other)
    {
        PinballScript pb = other.GetComponent<PinballScript>();
        if(pb)
        {
            Vector3 direction = other.gameObject.transform.position - gameObject.transform.position;
            pb.Bounce(bouncePower * direction.normalized);
        }
    }
}
