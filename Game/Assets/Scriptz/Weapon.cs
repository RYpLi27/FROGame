using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform transformPosition;
    public float fireRate = 1.0f;

    private float _nextFireTime = 0.0f;
    private void Awake()
    {
        if (transformPosition == null)
        {
            transformPosition = GetComponent<Transform>();
        }
    }

     void Update()
    {
        if (Time.timeSinceLevelLoad >= _nextFireTime && Input.GetAxis("Fire1") > 0)
        {
            Debug.Log("Fire");

            _nextFireTime = Time.timeSinceLevelLoad + 1.0f / fireRate;
        }
    }
}
