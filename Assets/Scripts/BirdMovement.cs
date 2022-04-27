
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private Animator mAnimator;

    private void Start()
    {
        mAnimator = GetComponent<Animator>();
    }
}
