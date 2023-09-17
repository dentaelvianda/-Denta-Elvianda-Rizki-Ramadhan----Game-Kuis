using TMPro;
using UnityEngine;

public class UI_PesanLevel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _tempatPesan = null;

    private void Awake()
    {
        if (gameObject.activeSelf)
            gameObject.SetActive(false);
    }
    
    public string Pesan
    {
        get => _tempatPesan.text;
        set => _tempatPesan.text = value;
        
    }
}
