using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Vector3 camOffset;
    private float movement;
    private float rotation;
    private Camera cam;

    private void Awake()
    {
        cam = Camera.allCameras[0];
        cam.transform.SetParent(transform);
        cam.transform.position= camOffset;
    }

    private void Update()
    {
        Movement();
        if (movement != 0)
        {
                tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }
        else
        {
            tankController.VeloZero();
        }
        if (rotation != 0) {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
        }
    }

    private void Movement()
    {
        movement = Input.GetAxisRaw("Vertical");
        rotation = Input.GetAxisRaw("Horizontal");
    }

    public void SetTankController(TankController _tankController)
	{
            tankController = _tankController;
	}
    
    public Rigidbody GetRigidBody()
    {
        return rb;
    }
}
