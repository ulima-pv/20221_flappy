using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public float scrollSpeed;

    public bool IsRunning = true;

    private Vector3 mInitialPosition;

    private void Start()
    {
        mInitialPosition = transform.position;
    }

    private void Update()
    {
        if (IsRunning)
        {
            float newPos = Mathf.Repeat(scrollSpeed * Time.time, 5.53f);
            transform.position = mInitialPosition - (newPos * Vector3.right);
        }
    }
}
