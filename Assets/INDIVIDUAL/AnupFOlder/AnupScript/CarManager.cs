using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public MeshRenderer FLeft, BLeft, FRight, BRight;
    public WheelCollider FLeftWheelCollider, BLeftWheelCollider, FRightWheelCollider, BRightWheelCollider;

    public Rigidbody RB;

    float fuelInput; //For Front Back
   float steeringInput; //For Left Right

    public float MotorPower;
    public float SteeringPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        ApplyMotor();
        ApplySteering();
        UpdateWheel();
    }

      public void FuelInput(float input)
    {
        fuelInput = input;
    }
    public void SteeringInput(float input)
    {
        steeringInput = input;
    }
    void ApplyMotor()
    {
        BLeftWheelCollider.motorTorque = MotorPower * fuelInput;
        BRightWheelCollider.motorTorque = MotorPower * fuelInput;

    }

    void ApplySteering()
    {
        FLeftWheelCollider.steerAngle = steeringInput * SteeringPower;
        FRightWheelCollider.steerAngle = steeringInput * SteeringPower;
    }

    void UpdateWheel()
    {
        UpdatePos(FLeftWheelCollider, FLeft);
        UpdatePos(FRightWheelCollider, FRight);
        UpdatePos(BLeftWheelCollider, BLeft);
        UpdatePos(BRightWheelCollider, BRight);
    }

    void UpdatePos(WheelCollider Col, MeshRenderer Mesh)
    {
        Quaternion quar;
        Vector3 Pos;
        Col.GetWorldPose(out Pos, out quar);
        Mesh.transform.position = Pos;
        Mesh.transform.rotation = quar;

    }
   
}

