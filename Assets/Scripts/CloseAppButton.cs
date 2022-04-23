using UnityEngine;
using UnityEngine.UI;

public class CloseAppButton : MonoBehaviour
{
    [SerializeField] private Button _closeButton;

    private void Awake()
    {
        _closeButton.onClick.AddListener(OnClick);
    }
    
    private void OnClick()
    {
        Application.Quit();
    }
}
