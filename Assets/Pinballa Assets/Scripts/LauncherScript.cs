using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class LauncherScript : MonoBehaviour
{
    

    public GameObject launcherPad;

    public RawImage powerMeter;
    public RectTransform rt;
    private float powerMeterMaxSize = 420f;
    private float currentMeterSize;

    public bool spaceBar = false;

    //

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rt = powerMeter.GetComponent<RectTransform>();
        //Set the power meter to the starting size; invisible when the game starts
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, 524);
        currentMeterSize = rt.sizeDelta.y;
        Debug.Log("Starting size: " + rt.sizeDelta.x);
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

        WindUp(spaceBar);
    }

    void GetInput()
    {
        Keyboard kb = Keyboard.current;

        if (kb == null)
        {
            return;
        }

        spaceBar = kb.spaceKey.isPressed;
    }

    void WindUp(bool isWinding)
    {
        if (!isWinding)
        {
            currentMeterSize--;
            if (currentMeterSize > 0)
            {
                currentMeterSize = powerMeterMaxSize;
            }
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, currentMeterSize);
        }
        else
        {
            if (currentMeterSize < powerMeterMaxSize)
            {
                currentMeterSize++;
                rt.sizeDelta = new Vector2(rt.sizeDelta.x, currentMeterSize);
            }
        }
    }
}
