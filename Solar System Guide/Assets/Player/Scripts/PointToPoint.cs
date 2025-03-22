using UnityEngine;
using System.Collections.Generic;

public class PointToPoint : MonoBehaviour
{
    public int CellId;
    public GameObject Point;
    public GameObject CurrentPoint;
    public bool isPressed;
    public bool isWatching;

    public List<GameObject> neighbors;


    private void Update()
    {
        if (!isPressed && CurrentPoint != null)
        {
            Destroy(CurrentPoint.gameObject);
            gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
        }

        if (Input.GetMouseButton(0) && isWatching)
        {
            if (CurrentPoint == null) 
            {
                GameObject currentNeighbor = null;

                foreach(var neigbor in neighbors)
                {
                    if (neigbor.GetComponentInChildren<SphereCollider>())
                    {
                        currentNeighbor = neigbor;
                    }
                }

                isPressed = true;


                if (currentNeighbor != null)
                {
                    if (currentNeighbor.GetComponentInChildren<SphereCollider>())
                    {
                        var currentpoint = Instantiate(Point, gameObject.transform.position, Quaternion.identity, gameObject.transform);
                        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                        CurrentPoint = currentpoint;
                    }
                }

                if (CellId == 0)
                {
                    var currentpoint = Instantiate(Point, gameObject.transform.position, Quaternion.identity, gameObject.transform);
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    CurrentPoint = currentpoint;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
        }
    }

    private void OnMouseEnter()
    {
        isWatching = true;
    }

    private void OnMouseExit()
    {
        isWatching = false;
    }

}
