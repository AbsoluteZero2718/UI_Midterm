using UnityEngine;


public class UIBehavior : MonoBehaviour
{
    public UIManager UIManager;
    public Pulse Pulse;
    public Jiggle jiggle;
    public FlipObject flip;
    public Slide slider;
    public Bounce boing;

    void Start()
    {
        UIManager.ShakeObject();
        Pulse.ObjectPulse();
        jiggle.JiggleObject();
        flip.Flip();
        slider.Sliding();
        boing.BounceObject();


    }
}
