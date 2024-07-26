using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class SpriteLookPlane : MonoBehaviour
{
    public Transform targetTransform;
    public bool canLookUpDown = false;
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        _transform.LookAt(targetTransform);
    } 
}
