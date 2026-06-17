using UnityEngine;

public class Plataforma : MonoBehaviour {

    public Vector2 PosicaoFinal;
    public Vector2 PosicaoInicial;

    Vector2 Alvo;



    private void Awake()
    {
        Alvo = PosicaoFinal;
    }




    private void Update()
    {
        if (Vector2.Distance(transform.position, Alvo) < 0.1f)
        {
            if (Alvo == PosicaoFinal)
                Alvo = PosicaoInicial;
        } else { Alvo = PosicaoFinal; }
    
    transform.position = Vector2.MoveTowards(transform.position, Alvo, Time.deltaTime* 5f);
    }
  


}
