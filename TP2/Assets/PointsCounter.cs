using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    public GameObject Charge;
    private int areacount = 0;
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = Charge.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Charge)
        {
            areacount++;
            Debug.Log("Counter: " + areacount);
            Charge.transform.position = originalPosition;
        }
    }
}