using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundAnimator : MonoBehaviour
{
    [SerializeField] private  Image _backgroundImage;
    [SerializeField] private Sprite[]  _animationFrame;
    [SerializeField] private float _frameRate ;
    private int _currentFrame = 0;
    // Start is called before the first frame update
    void Start()
    {

        //Check to see if the images are avalabile
        if(_animationFrame.Length > 0 && _backgroundImage != null)
        {
            StartCoroutine(StartAnimation());
        }
        else{
            // Download(images)
            Debug.Log("Images missing");
        }
        
    }

    // Update is called once per frame
   private IEnumerator StartAnimation()
   {
    while(true)
    {
       _backgroundImage.sprite = _animationFrame[_currentFrame];
       _currentFrame += 1;
       yield return new WaitForSeconds(_frameRate);
       if(_currentFrame > 25) _currentFrame = 0;
    }
   }
}
