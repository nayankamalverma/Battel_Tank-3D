using UnityEngine;

public class TankController 
{
    private TankView tankView;
    private TankModel tankModel;

    public TankController(TankModel tankModel,TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = tankView;

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}