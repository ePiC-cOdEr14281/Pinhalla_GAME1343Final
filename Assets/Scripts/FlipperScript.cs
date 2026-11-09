using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperScript : MonoBehaviour
{
    public GameObject leftFlipper;
    public GameObject rightFlipper;

    //Vector3 leftStartRotation =

    public float flipRotationRate = 100.0f;

    //Input Variables
    bool left = false; //F Key X-
    bool right = false; //J Key X+

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

        float horizontal = 0;
        if(left)
        {
            horizontal = -1;
        }
        if (right)
        {
            horizontal = 1;
        }

        RotateFlipper(horizontal);
    }

    void GetInput()
    {
        Keyboard kb = Keyboard.current;

        if (kb == null)
        {
            return;
        }

        left = kb.fKey.isPressed;
        right = kb.jKey.isPressed;
    }

    void RotateFlipper(float value)
    {
        if (value < 0)
        {
            //Rotates the Left Flipper in the -X direction
            leftFlipper.transform.Rotate(Vector3.left * value * flipRotationRate * Time.deltaTime);
        }
        if (value > 0)
        {
            //Rotates the Right Flipper in the +X direction
            rightFlipper.transform.Rotate(Vector3.right * value * flipRotationRate * Time.deltaTime);
        }
    }
}
