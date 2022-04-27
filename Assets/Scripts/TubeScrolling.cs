
using System;
using UnityEngine;

public class TubeScrolling : MonoBehaviour
{
    public float scrollSpeed;
    public float gap;
    public Transform upperTube;
    public Transform lowerTube;

    private Vector3 mScreenBounds;
    private Vector2 mTubeSize;

    private void Start()
    {
        mScreenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, 0f)
        );

        mTubeSize = upperTube.GetComponent<SpriteRenderer>().bounds.size;

        YPositioning();
    }

    private void Update()
    {
        transform.position -= scrollSpeed * Time.deltaTime * Vector3.right;

        if (transform.position.x < -3f)
        {
            Repositioning();
        }
    }

    private void Repositioning()
    {
        transform.position = new Vector3(
            7f,
            transform.position.y,
            0f
        );
        YPositioning();
    }

    private void YPositioning()
    {
        // Posicionamiento del tubo de arriba
        float maxPositionY = -mScreenBounds.y + mTubeSize.y + gap + (mTubeSize.y / 2f);
        float minPositionY = mScreenBounds.y - mTubeSize.y / 2f;

        float upperPosition = UnityEngine.Random.Range(minPositionY, maxPositionY);

        // Posicionando tubo de arriba
        upperTube.position = new Vector3(
            upperTube.position.x,
            upperPosition,
            0f
        );

        // Posicionando tubo de abajo
        lowerTube.position = new Vector3(
            lowerTube.position.x,
            upperPosition - mTubeSize.y - gap,
            0f
        );

    }
}
