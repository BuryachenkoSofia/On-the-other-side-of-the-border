using UnityEngine;

public class CameraControll : MonoBehaviour
{

    public Vector2 DefaultResolution = new Vector2(1920, 960);
    [Range(0f, 1f)] public float WidthOrHeight = 0.5f;
    private Camera Camera;
    private float initialCameraSize;
    private float needAspect;

    private void Start()
    {
        Camera = GetComponent<Camera>();
        initialCameraSize = Camera.orthographicSize;
        needAspect = DefaultResolution.x / DefaultResolution.y;
    }
    private void FixedUpdate()
    {
        float constWidthSize = initialCameraSize * (needAspect / Camera.aspect);
        Camera.orthographicSize = Mathf.Lerp(constWidthSize, initialCameraSize, WidthOrHeight);
    }
}