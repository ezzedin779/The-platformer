using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;
    public float RotationSensitivity = 8.0f;
    public bool IsInverted;

    private float RotationMin = -40.0f;
    private float RotationMax = 80.0f;

    public float SmoothTime = 0.12f;

    public Transform Target;

    private Vector3 TargetRotation;
    private Vector3 CurrentVel;

    void LateUpdate()
    {
        Yaxis += Input.GetAxis("Mouse X") * RotationSensitivity;
        Xaxis -= Input.GetAxis("Mouse Y") * RotationSensitivity;

        Xaxis = Mathf.Clamp(Xaxis, RotationMin, RotationMax);

        if(!IsInverted)
        {
            TargetRotation = Vector3.SmoothDamp(TargetRotation, new Vector3(Xaxis, Yaxis),ref CurrentVel, SmoothTime);
        }
        else
        {
            TargetRotation = Vector3.SmoothDamp(TargetRotation, new Vector3(Xaxis, -Yaxis),ref CurrentVel, SmoothTime);
        }
        transform.eulerAngles = TargetRotation;

        transform.position = Target.position - transform.forward * 6.25f;
    }
}