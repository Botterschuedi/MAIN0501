using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
void OnCollisionEnter(Collision Collision)
{
if (Collision.gameObject.GetComponent<ArticulationBody>() != null){
FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();joint.connectedArticulationBody = Collision.articulationBody;}
}
    // Update is called once per frame
void Update()
{
if (Input.GetKey(KeyCode.Space))
{
Destroy(this.gameObject.GetComponent<FixedJoint>());
}
}
}
