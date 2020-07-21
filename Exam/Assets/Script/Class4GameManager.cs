using UnityEngine;
using UnityEngine.SceneManagement;

public class Class4GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("第三題");
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("第五題");
        }
    }
}
