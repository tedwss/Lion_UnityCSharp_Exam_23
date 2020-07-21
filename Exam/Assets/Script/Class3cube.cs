using UnityEngine;
using UnityEngine.SceneManagement;

public class Class3cube : MonoBehaviour
{
    public GameObject cube;

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 pos = new Vector3(i * 1.2f, 0, 0);

            Instantiate(cube, pos, Quaternion.identity);
        }

        for (int i = 0; i < 2; i++)
        {
            Vector3 pos = new Vector3(i * 1.2f, i * 1.2f, 0);

            Instantiate(cube, pos, Quaternion.identity);
        }

        for (int i = 0; i < 2; i++)
        {
            Vector3 pos = new Vector3(i * 1.2f, i * -1.2f, 0);

            Instantiate(cube, pos, Quaternion.identity);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("第二題");
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("第四題");
        }
    }
}
