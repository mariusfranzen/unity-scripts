using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTowardsMouse2D : MonoBehaviour
{
    public float RotationSpeed = 5f;

    void Update()
    {
        HandleRotation();
    }

    void HandleRotation()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, RotationSpeed * Time.deltaTime);
    }
}
