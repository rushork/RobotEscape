using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;

    void Start() {
        followTarget = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (followTarget != null) {
            targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y + 1f, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);      
        }
    }
}
