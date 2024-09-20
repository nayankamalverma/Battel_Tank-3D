using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelectonUI : MonoBehaviour
{
    [SerializeField] private TankSpawner tankSpawner;

    public void GreenTankSelected()
    {
        Debug.Log("green");
        tankSpawner.CreateTank(TankTypes.GreenTank);
        DeactivateSelectionPanel();
    }
    
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        DeactivateSelectionPanel();
    }
    
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        DeactivateSelectionPanel();
    }

    private void DeactivateSelectionPanel()
    {
        this.gameObject.SetActive(false);
    }
}
