using UnityEngine;
using System.Collections;

public class MouseLookScript : MonoBehaviour {

    [HideInInspector]
    public float xRotation;
    [HideInInspector]
    public float yRotation;
    public float lookSense = 5;
    [HideInInspector]
    public float currXRotation;
    [HideInInspector]
    public float currYRotation;
    [HideInInspector]
    public float xRotationVelocity;
    [HideInInspector]
    public float yRotationVelocity;
    public float smoothDampTime = 0.1f;

    void Update() {

        xRotation -= Input.GetAxis("Mouse Y") * lookSense;
        yRotation += Input.GetAxis("Mouse X") * lookSense;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        currXRotation = Mathf.SmoothDamp(currXRotation, xRotation, ref xRotationVelocity, smoothDampTime);
        currYRotation = Mathf.SmoothDamp(currYRotation, yRotation, ref yRotationVelocity, smoothDampTime);

        transform.rotation = Quaternion.Euler(currXRotation, currYRotation, 0);
    }
}
