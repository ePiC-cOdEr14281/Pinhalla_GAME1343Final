using UnityEngine;

public class VoidPitScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pit Found: " + other.gameObject.name);

        PinballScript pb = other.gameObject.GetComponent<PinballScript>();
        if (pb)
        {
            //pb.Destroy();
            pb.Reset();
            Debug.Log("Pinball Reset!");
        }
    }
    
}
