using UnityEngine;
using UnityEngine.SceneManagement;
public class scenechanger : MonoBehaviour
{
    public void ChangeScene(int n) {
        SceneManager.LoadScene(n);
        
    }
}