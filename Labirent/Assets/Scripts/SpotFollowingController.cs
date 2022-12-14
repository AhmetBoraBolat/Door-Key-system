using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotFollowingController : MonoBehaviour
{[SerializeField] private Transform ballTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] [Range(0,5)] private float LerpValue;
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraFollow();
    }

    private void SetCameraFollow()
    {
        newPosition = Vector3.Lerp(transform.position,ballTransform.position + offset, LerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
