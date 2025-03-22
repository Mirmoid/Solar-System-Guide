using UnityEngine;

public class PlanetsRotate : MonoBehaviour
{
    public Transform rotateObj;
    public Transform aroundObj;
    public float rotSpeed = 0.1f;
    void Update()
    {
        Rotator();
    }
    void Rotator()
    {
        rotateObj.RotateAround(aroundObj.position, new Vector3(0, 1, 0), rotSpeed);
    }
}
