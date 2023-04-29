
using UnityEngine.Rendering;
using UnityEngine;

public class Randomness : MonoBehaviour
{
    private Volume volume;
    
    public float[] randomHueShitf;

    void Start()
    {
        volume = GetComponent<Volume>();
       
        
    }
}
