using UnityEngine;

public class GrassDensity : MonoBehaviour
{
    [SerializeField][Range(0, 5)] private float _range;

    private void Awake()
    {
        var terrain = GetComponent<Terrain>();
        terrain.detailObjectDensity = _range;
    }
}
