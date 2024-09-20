using UnityEngine;

public class TankController 
{
    private TankView tankView;
    private TankModel tankModel;
    private Rigidbody rigidBody;

    public TankController(TankModel tankModel,TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = GameObject.Instantiate<TankView>(tankView);
        tankModel.SetTankController(this);
        this.tankView.SetTankController(this);
        rigidBody = this.tankView.GetRigidBody();
        this.tankView.ChangeColor(tankModel.color);
    }


    public void Move(float move, float speed)
    {
        rigidBody.velocity = tankView.gameObject.transform.forward * move * speed;
    }
    public void VeloZero()
    {
        rigidBody.velocity = Vector3.zero;
    }
    public void Rotate(float rotation, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f, rotation * rotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rigidBody.MoveRotation(rigidBody.rotation* deltaRotation);
    }

    public TankModel GetTankModel() => tankModel;
}