using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Class2Player : MonoBehaviour
{
    public Sprite sprite;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("第一題");
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("第三題");
        }
    }
}
