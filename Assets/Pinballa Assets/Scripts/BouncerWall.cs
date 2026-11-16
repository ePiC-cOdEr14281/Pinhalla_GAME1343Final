using UnityEngine;

public class BouncerWall : MonoBehaviour
{

    public WallDirectionEnum direction = WallDirectionEnum.North;
    public float bouncePower = 1000;

    private void OnTriggerEnter(Collider other)
    {
        PinballScript pb = other.gameObject.GetComponent<PinballScript>();
        if (!pb)
        {
            return;
        }

        if (direction == WallDirectionEnum.North)
        {
            pb.Bounce(Vector3.forward * bouncePower);
        }
        else if (direction == WallDirectionEnum.South)
        {
            pb.Bounce(Vector3.back * bouncePower);
        }
        else if (direction == WallDirectionEnum.East)
        {
            pb.Bounce(Vector3.right * bouncePower);
        }
        else if (direction == WallDirectionEnum.West)
        {
            pb.Bounce(Vector3.left * bouncePower);
        }
    }
}
