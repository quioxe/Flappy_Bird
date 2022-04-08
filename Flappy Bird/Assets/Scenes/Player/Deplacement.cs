using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public float jumpPower = 10;
    public bool jumpKeyWasPressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);

            jumpKeyWasPressed = false;
        }
    }






    private void Jump()
    {
        jumpKeyWasPressed = true;
    }
}
