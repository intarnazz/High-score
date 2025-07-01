using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float sidewaisForce = 500f;
    public Rigidbody rb;

    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(0, 0, sidewaisForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(0, 0, -sidewaisForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Keyboard.current.spaceKey.isPressed)
        {
            rb.AddForce(0, sidewaisForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
