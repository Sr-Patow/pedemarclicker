using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoTimer;
    [SerializeField] float tempoRestante;


    public string telaPraEsconder = "FimDeJogo";

    public bool acabou = false;
    // Update is called once per frame



    void Start()
    {
        Transform filho = transform.Find(telaPraEsconder);
        filho.gameObject.SetActive(false);

        Time.timeScale = 1;
        acabou = false;
    }
    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante = tempoRestante - Time.deltaTime;
        }

        else
        {
            tempoRestante = 0;
            //cabou o jogo
            textoTimer.color = Color.yellow;
            acabou = true;
            Time.timeScale = 0;
            Transform filho = transform.Find(telaPraEsconder);
            filho.gameObject.SetActive(true);
        }
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);

    }
}
