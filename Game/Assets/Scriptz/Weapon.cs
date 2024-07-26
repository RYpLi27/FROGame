using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform transformPosition;

    private void Awake()
    {
        if (transformPosition == null)
        {
            transformPosition = GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
