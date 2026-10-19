using System.Collections;
using UnityEngine;

public class BridgeControlMechanism : MonoBehaviour
{
    public Drawbridge trackedDrawbridge;
    public bool doRotate = false;
    public float rotateTime = 2.0f;
    private float finishRotating;

    // Update is called once per frame
    void Update()
    {
        if (doRotate)
        {
            transform.Rotate(0f, 1f, 0f);
        }

        if (Time.time >= finishRotating)
        {
            doRotate = false;
        }
    }

    public void RotateMechanism()
    {
        if (trackedDrawbridge.drawbridgePosition == Drawbridge.BridgePosition.Raised)
        {
            doRotate = true;
            finishRotating = Time.time + rotateTime;
        }
    }
}
