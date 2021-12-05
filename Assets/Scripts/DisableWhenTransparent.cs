using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class DisableWhenTransparent : MonoBehaviour
{
    private Image image;
    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (image.color.a <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
