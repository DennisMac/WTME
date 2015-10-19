using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
    private static bool fadeIn = false;
    public float fadeInSpeed = 1f;
    Image image;
    // Use this for initialization
    void Start() {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update() {
        if (image.color.a > 0)
        {
            if (fadeIn)
            {
                image.color = new Color(image.color.r, image.color.b, image.color.b,
                    image.color.a - Time.deltaTime * fadeInSpeed);
            }
        }
    }
	
    public static void SetFadeIn(bool go)
    {
        fadeIn = go;
    }
}
