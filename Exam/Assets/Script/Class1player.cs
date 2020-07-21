using UnityEngine;
using UnityEngine.SceneManagement;

public class Class1player : MonoBehaviour
{
    [Header("速度"), Range(1f, 100f)]
    public float speed = 1;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Time.deltaTime * 2, 0, 0);
        }

        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("第五題");
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("第二題");
        }
    }

}
