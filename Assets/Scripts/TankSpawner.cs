using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    [SerializeField] private List<Tank> tankList;
    [SerializeField] private TankView tankView;

    public void CreateTank(TankTypes tankType)
    {
        int type = (int)tankType;
        TankModel tankModel = new TankModel(tankList[type].movementSpeed, tankList[type].rotationSpeed, tankList[type].tankType, tankList[type].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
