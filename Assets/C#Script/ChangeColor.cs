using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class ChangeColor : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color color1 = new Color(0.7f, 1.0f, 1.0f);
    public Color color2 = new Color(1.0f, 0.7f, 1.0f);
    public Color color3 = new Color(1.0f, 1.0f, 0.7f);
    Color lerpColor;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color currentColor = spriteRenderer.color;

        if(currentColor.b > 0.99 && !(currentColor.r > 0.99f)){
            lerpColor = Color.Lerp(currentColor, color2, Time.deltaTime);
        }
        else if(currentColor.r > 0.99 && !(currentColor.g > 0.99f)){
            lerpColor = Color.Lerp(currentColor, color3, Time.deltaTime);
        }

        else if(currentColor.g > 0.99 && !(currentColor.b > 0.99f)){
            lerpColor = Color.Lerp(currentColor, color1, Time.deltaTime);
        }

        spriteRenderer.color = lerpColor;
    }
}
