using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _10_11_ImageBar : MonoBehaviour
{
    public Image HPBar;
    public float duration;
    private float tmpDuration;
    // Start is called before the first frame update
    void Start()
    {
        tmpDuration = duration;
    }

    // Update is called once per frame
    void Update()
    {
        MinusHp();
        FullHp();
    }
    public void MinusHp()
    {
        tmpDuration -= Time.deltaTime;
        HPBar.fillAmount = tmpDuration / duration;
    }
    public void FullHp()
    {
        if(HPBar.fillAmount == 0)
        {
            HPBar.fillAmount = 1;
            tmpDuration = duration;
        }
    }
    public void ChangesSprite(string _name)
    {
        HPBar.sprite = Resources.Load<Sprite>(_name);
    }
}
