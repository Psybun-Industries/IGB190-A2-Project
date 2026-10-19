using UnityEngine;

public class OneWayDoor : MonoBehaviour
{
    public bool isOpen = false;
    private Vector3 currentPosition;
    private Vector3 openPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentPosition = transform.eulerAngles;
        float targetAngle = currentPosition.y + 110.0f;
        openPosition = new Vector3(0f, targetAngle, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            currentPosition = new Vector3(
                0f, Mathf.LerpAngle(currentPosition.y, openPosition.y, Time.deltaTime), 0f);

            transform.eulerAngles = currentPosition;
        }
    }

    public void SetOpen()
    {
        isOpen = true;
    }
}
