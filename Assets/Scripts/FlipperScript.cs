using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class FlipperScript : MonoBehaviour
{
    public GameObject leftFlipper;
    public GameObject rightFlipper;

    public GameObject leftPivot;
    public GameObject rightPivot;

    Quaternion leftStartingRotation;
    Quaternion rightStartingRotation;

    public float flipRotationRate = 500.0f;

    //Input Variables
    bool left = false; //F Key X-
    bool right = false; //J Key X+

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftStartingRotation = leftFlipper.transform.rotation;
        rightStartingRotation = rightFlipper.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

        float l_horizontal = 0, r_horizontal = 0;
        if(left)
        {
            l_horizontal = -1;
        }
        if (right)
        {
            r_horizontal = 1;
        }

        RotateFlipper(l_horizontal, r_horizontal);
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

    void RotateFlipper(float leftValue, float rightValue)
    {
        if (leftValue < 0)
        {
            //Rotates the Left Flipper in the Up direction
            leftPivot.transform.rotation = Quaternion.RotateTowards(leftPivot.transform.rotation, leftStartingRotation * Quaternion.Euler(0, -25, 0), flipRotationRate * Time.deltaTime);
        }
        if (rightValue > 0)
        {
            //Rotates the Right Flipper in the Up direction
            rightPivot.transform.rotation = Quaternion.RotateTowards(rightPivot.transform.rotation, rightStartingRotation * Quaternion.Euler(0, 25, 0), flipRotationRate * Time.deltaTime);
        }
        if (leftValue == 0)
        {
            //Resets the Flippers to their starting rotation
            leftPivot.transform.rotation = Quaternion.RotateTowards(leftPivot.transform.rotation, leftStartingRotation, flipRotationRate * Time.deltaTime);
        }
        if  (rightValue == 0)
        {
            rightPivot.transform.rotation = Quaternion.RotateTowards(rightPivot.transform.rotation, rightStartingRotation, flipRotationRate * Time.deltaTime);
        }
    }
}
