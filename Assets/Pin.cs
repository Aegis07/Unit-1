using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isKnockedDown;



    void Start()
    {
       
    }

    
    void Update()
    {
        if (transform.rotation.eulerAngles.x < -30) 
        {
            isKnockedDown = true; 
        }
        if (transform.rotation.eulerAngles.x > 30)
        {
            isKnockedDown = true;
        }
        if (transform.rotation.eulerAngles.z < -30)
        {
            isKnockedDown = true;
        }
        if (transform.rotation.eulerAngles.z > 30)
        {
            isKnockedDown = true;
        }
    }
}
