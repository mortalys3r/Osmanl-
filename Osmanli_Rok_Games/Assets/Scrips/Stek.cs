using UnityEngine;

public class Stek : MonoBehaviour
{
    [SerializeField] private string karakter;
    [SerializeField] private string meslek;
    public string istek;
    public Inventory envanter;
    


    


    [Header("evet dersen")]

    public int din_durume, para_durume, halk_durume, güvenlik_durume;
    public int din_durumq, para_durumq, halk_durumq, güvenlik_durumq;



    public void evet()
    {
        envanter.olcak();
        envanter.din_olay(din_durume);
        envanter.para_olay(para_durume);
        envanter.halk_olay(halk_durume);
        envanter.güvenlik_olay(güvenlik_durume);



    }
    public void hayır()
    {
        envanter.olcak();
        envanter.din_olay(din_durumq);
        envanter.para_olay(para_durumq);
        envanter.halk_olay(halk_durumq);
        envanter.güvenlik_olay(güvenlik_durumq);

    }


}
