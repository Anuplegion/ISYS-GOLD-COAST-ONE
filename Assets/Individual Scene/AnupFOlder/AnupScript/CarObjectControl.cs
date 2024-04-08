using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObjectControl : MonoBehaviour
{
    public GameObject car;
    public float value;
    public Vector3 sizeChange;


    public void RotateCarRight()
    {
        car.transform.Rotate(0f, 5f, 0f); 
    }
    public void RotateCarLeft()
    {
        car.transform.Rotate(0f, -5f, 0f);
    }

    public void GrowCar()
    {
        car.transform.localScale = car.transform.localScale + sizeChange;
    }
    public void ShrinkCar()
    {
        car.transform.localScale = car.transform.localScale - sizeChange;
    }

    public void MoveCarDOWN()
    {
        value = value - 0.3f;
        car.transform.position = new Vector3(0, value, 0);
    }
    public void MoveCarUP()
    {
        value = value + 0.3f;
        car.transform.position = new Vector3(0, value, 0);
    }
    public void MoveCarLeft()
    {
        value = value + 0.3f;
        car.transform.position = new Vector3(0, 0, value);
    }
    public void MoveCarRight()
    {
        value = value - 0.3f;
        car.transform.position = new Vector3(0, 0, value);
    }
}
