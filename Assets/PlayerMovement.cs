using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float spaceForce = 500f;
    public float sidewaisForce = 500f;
    public bool isSpace = true;
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
        if (Keyboard.current.spaceKey.isPressed && isSpace)
        {
            isSpace = false;
            rb.AddForce(0, spaceForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Keyboard.current.rKey.isPressed)
        {
            GameManager gm = FindFirstObjectByType<GameManager>();
            if (gm != null)
                gm.EndGame();
            else
                Debug.LogWarning("GameManager not found");
        }

    }
}
