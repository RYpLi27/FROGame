using UnityEngine;

public class SpriteLook : MonoBehaviour
{
    [SerializeField] bool lockUpDown = true;
    // Update is called once per frame
    void Update()
    {
        if (lockUpDown)
        {
        transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}
