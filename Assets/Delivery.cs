using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float delayTime = 0.5f;

    [SerializeField] Color32 hasPackageColor = new Color32(255, 24, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("oh!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, delayTime);

        }
        else if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Delievery Clear!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

        else if (other.tag == "Boost")
        {

        }
    }
}
