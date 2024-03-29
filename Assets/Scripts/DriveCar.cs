using UnityEngine;

public class DriceCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D FrontTire;
    [SerializeField] private Rigidbody2D BackTire;
    [SerializeField] private Rigidbody2D Car;
    [SerializeField] private float MoveSpeed = 200f;
    [SerializeField] private float RotationSpeed = 750f;

    private float moveInput;

    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal"); 

        //if (Input.GetKey(KeyCode.D))
        //    // how i can save the info about movement???
        //    transform.position += transform.forward * Time.fixedDeltaTime * MoveSpeed;
        
        //if (Input.GetKey(KeyCode.A))
        //    transform.position += -transform.forward * Time.fixedDeltaTime * MoveSpeed;

        //if (Input.GetKey(KeyCode.W))
        //    transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * MoveSpeed, Space.World);

        //if (Input.GetKey(KeyCode.S))
        //    transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * MoveSpeed, Space.World);
    }

    private void FixedUpdate()
    {
        FrontTire.AddTorque(- moveInput *MoveSpeed * Time.fixedDeltaTime);
        BackTire.AddTorque(-moveInput * MoveSpeed * Time.fixedDeltaTime);
        Car.AddTorque(moveInput * RotationSpeed * Time.fixedDeltaTime);
    }
}
