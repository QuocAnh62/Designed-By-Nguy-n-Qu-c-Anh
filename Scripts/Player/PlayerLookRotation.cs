using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookRotation : MonoBehaviour
{
    private float turnSmooth = 0.2f;
    float turnSmoothVelocity;

    protected void LookRotation(FixedJoystick joystick)
    { 
        Vector3 dir = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        if (dir.magnitude >= 0.01f)
        {
            // Tính góc mục tiêu dựa trên hướng của Joystick
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;

            // Dùng SmoothDampAngle để làm cho rotation diễn ra từ từ
            float smoothAngle = 
                Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmooth);

            // Cập nhật rotation của player
            transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);
        }
    }
}
