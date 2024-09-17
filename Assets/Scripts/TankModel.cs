using UnityEngine;

public class TankModel
{
    public float movementSpeed { get; private set; } 
    public float rotationSpeed { get; private set; }

    private TankController tankController;

    public TankModel(float movementSpeed, float rotationSpeed)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}