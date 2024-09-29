using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ControlGrue : MonoBehaviour
{
public float torque = 250f;
public float forceChariot = 500f;
public float forceMoufle = 500f;
public ArticulationBody pivot;
public ArticulationBody chariot;
public ArticulationBody moufle;
public Camera cameraA;
public Camera cameraB;
// Start is called before the first frame updatevoid Start()
void Start()
{
    cameraA.enabled = true;
    cameraB.enabled = false;
}
// Update is called once per frame
void Update()
{
//commandes pour la fleche
if (Input.GetKey(KeyCode.LeftArrow))
{
pivot.AddTorque(transform.up * -torque);
}
if (Input.GetKey(KeyCode.RightArrow))
{
pivot.AddTorque(transform.up * torque);
}
//commandes pour le chariot
if (Input.GetKey(KeyCode.UpArrow))
{
chariot.AddRelativeForce(transform.right * forceChariot);}
if (Input.GetKey(KeyCode.DownArrow))
{
chariot.AddRelativeForce(transform.right * -forceChariot);}
//commande pour la moufle
if (Input.GetKey(KeyCode.LeftShift))
{
moufle.AddRelativeForce(transform.up * forceMoufle);}
if (Input.GetKey(KeyCode.LeftControl))
{
moufle.AddRelativeForce(transform.up * -forceMoufle);}
if (Input.GetKeyDown(KeyCode.V))
    {
        if (cameraA.enabled)
        {
            cameraA.enabled = false;
            cameraB.enabled = true;
        }
        else if (cameraB.enabled)
        {
            cameraA.enabled = true;
            cameraB.enabled = false;
        }
    }
}
}
