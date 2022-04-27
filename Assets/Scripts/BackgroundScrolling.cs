using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public float scrollSpeed;

    private Vector3 mInitialPosition;

    private void Start()
    {
        mInitialPosition = transform.position;
    }

    private void Update()
    {
        float newPos = Mathf.Repeat(scrollSpeed * Time.time, 5.53f);
        transform.position = mInitialPosition - (newPos * Vector3.right);
    }
}
