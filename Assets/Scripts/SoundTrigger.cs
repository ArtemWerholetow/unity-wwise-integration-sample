using UnityEngine;
using System.Collections;

public class SoundTrigger : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        uint bankID;
        AkSoundEngine.LoadBank("Car.bnk", AkSoundEngine.AK_DEFAULT_POOL_ID, out bankID);
        AkSoundEngine.PostEvent(AK.EVENTS.PLAY_ENGINE, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
