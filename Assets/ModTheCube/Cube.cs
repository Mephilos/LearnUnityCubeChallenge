using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        CubeMove();
        transform.Rotate(10.0f * Time.deltaTime, 30.0f * Time.deltaTime, 50.0f * Time.deltaTime);
        CubeScale();
        CubeColor();
    }
    //이동 기능
    void CubeMove()
    {
        // horizontalInput = Input.GetAxis("Horizontal");
        // forwardInput = Input.GetAxis("Vertical");

        // transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        // transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * horizontalInput);
       
        float radius = 5f;          // 원의 반지름
        float speed = 1f;           // 회전 속도 (radian/sec)
        Vector3 center = Vector3.zero; // 중심점 위치
        float angle = Time.time * speed; // 시간에 따라 각도 증가

        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;
        float y = Mathf.Cos(angle) * radius;

        transform.position = new Vector3(center.x + x, center.y + y, center.z + z);
    }
    void CubeScale()
    {
        float size = 5f;          // 최대 크기
        float speed = 1f;           // 변화 속도 (radian/sec)

        float angle = Time.time * speed; // 시간에 따라 각도 증가

        float x = Mathf.Cos(angle) * size;

        transform.localScale = new Vector3(x, x, x);
    }
    void CubeColor()
    {
        Material material = Renderer.material;

        float size = 1.0f;          // 최대 크기
        float speed = 1.0f;           // 변화 속도 (radian/sec)

        float angle = Time.time * speed; // 시간에 따라 각도 증가

        float r = Mathf.Cos(angle) * size;
        float g = Mathf.Sin(angle) * size;
        float b = Mathf.Cos(angle) * size;
        material.color = new Color(r, g, b, r);
    }
}
