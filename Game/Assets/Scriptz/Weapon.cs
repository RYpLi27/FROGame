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
        if (Input.GetAxis("Fire1") > 0)
        {
            shoot();
            Debug.Log("Fire");

        }
    }

    private void shoot()
    {
        if (Time.timeSinceLevelLoad < _nextFireTime)
        {
            return;
        }
            if (Physics.Raycast(transformPosition.position, transformPosition.forward, out RaycastHit hitInfo))
            {
                Debug.Log(hitInfo.collider);
            }
            _nextFireTime = Time.timeSinceLevelLoad + 1.0f / fireRate;
    }

}
