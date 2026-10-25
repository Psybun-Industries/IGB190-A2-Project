using System.Collections;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.UIElements;

public class Drawbridge : MonoBehaviour
{
    public enum BridgePosition
    { Raised, Lowered, };
    public BridgePosition drawbridgePosition = BridgePosition.Raised;

    private Vector3 raisedPos = new Vector3(45f, 0f, 0f);
    private Vector3 loweredPos = new Vector3(0f, 0, 0);

    private void Update()
    {
        ChangePosition();
    }

    private void ChangePosition()
    {
        switch (drawbridgePosition)
        {
            case BridgePosition.Raised:
                transform.eulerAngles = raisedPos;
                break;

            case BridgePosition.Lowered:
                transform.eulerAngles = loweredPos;
                break;
        }
    }

    public void LowerDrawbridge()
    {
        drawbridgePosition = BridgePosition.Lowered;
    }
}
