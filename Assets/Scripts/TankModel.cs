using UnityEngine;

public class TankModel
{
    public float movementSpeed { get; private set; } 
    public float rotationSpeed { get; private set; }
    public TankTypes tankType { get; private set; }
    public Material color {  get; private set; }

    private TankController tankController;

    public TankModel(float movementSpeed, float rotationSpeed, TankTypes tankType, Material color)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        this.tankType = tankType;
        this.color = color;
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}