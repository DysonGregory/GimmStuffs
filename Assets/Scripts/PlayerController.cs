using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float horizontalSpeed = 20f;
    public float verticalSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            MoveRight();
        }
        if (Keyboard.current.aKey.isPressed)
        {
            MoveLeft();
        }
        if (Keyboard.current.wKey.isPressed)
        {
            MoveUp();
        }
        if (Keyboard.current.sKey.isPressed)
        {
            MoveDown();
        }
    
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log(GetOwlPosition());
        }

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            ChangeSize(0.1f);
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            ChangeSize(-0.1f);
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            ResetOwl();
        }
    }

    void MoveLeft()
    {
        transform.position += Vector3.left * horizontalSpeed * Time.deltaTime;
    }

    void MoveRight()
    {
        transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
    }

    void MoveUp()
    {
        transform.position += Vector3.up * verticalSpeed * Time.deltaTime;
    }

    void MoveDown()
    {
        transform.position += Vector3.down * verticalSpeed * Time.deltaTime;
    }

    string GetOwlPosition()
    {
        return transform.position.x + ", " + transform.position.y;
    }

    void ChangeSize(float amount)
    {
        float newSize = transform.localScale.x + amount;
        newSize = Mathf.Clamp(newSize, 0.8f, 1.2f);
        transform.localScale = new Vector3(newSize, newSize, 1f);
    }

    void ResetOwl()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}