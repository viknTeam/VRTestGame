using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class MovementScript : MonoBehaviour
{
    public SteamVR_Action_Vector2 Movement;
    public Transform MainCamera;
    public CapsuleCollider capsuleCollider;

    
    private void FixedUpdate()
    {
        Vector3 movement = Player.instance.hmdTransform.TransformDirection(new Vector3(Movement.axis.x, 0, Movement.axis.y));
        transform.position += Vector3.ProjectOnPlane(Time.deltaTime * movement * 2f,Vector3.up);
        float distanceFromFloor = Vector3.Dot(MainCamera.localPosition, Vector3.up);
        capsuleCollider.height = Mathf.Max(capsuleCollider.radius,distanceFromFloor);
        capsuleCollider.center = MainCamera.localPosition - 0.5f * distanceFromFloor * Vector3.up;
    }
}
