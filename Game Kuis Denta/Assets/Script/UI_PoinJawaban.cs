using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_PoinJawaban : MonoBehaviour
{
    [SerializeField]
    private UI_PesanLevel _tempatPesan = null;
    
    [SerializeField]
    private TextMeshProUGUI _teksJawaban = null;
    
    [SerializeField]
    private bool _adalahBenar = false;

    public void PilihJawaban()
    {
        _tempatPesan.Pesan = $"Jawaban {_teksJawaban.text} adalah {_adalahBenar}";
      //Debug.Log($"Jawaban anda {_teksJawaban.text} adalah ({_adalahBenar})");
    }
    public void SetJawaban(string teksJawaban, bool adalahBenar)
    {
        _teksJawaban.text = teksJawaban;
        _adalahBenar = adalahBenar;
    }
}
