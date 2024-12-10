using UnityEngine;

[RequireComponent(typeof(Light))]
public class SunFon : MonoBehaviour
{
    private Color _colorFon;

    private void Start()
    {
        NewFon();
    }
    public void NewFon()
    {
        _colorFon = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<Light>().color = _colorFon;
    }
}
