using Unity.VisualScripting;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isKnockedDown;
    public Vector3 originalPosition;
    public AudioSource pinStrikeAudio;


    void Start()
    {
       originalPosition = transform.position;
    }

    
    void Update()
    {
        if( Vector3.Angle( transform.up , Vector3.up ) > 15 )
        {
            
            isKnockedDown = true;
            
        }
        if (isKnockedDown)
        {
            pinStrikeAudio.Play();
        }
    }
}
