using UnityEngine;

public class Circle : MonoBehaviour, ITocavel
{
    public void Tocar()
    {
        var renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.color = Color.blue;
    }
}
