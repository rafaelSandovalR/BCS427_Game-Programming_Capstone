using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagicSystem : MonoBehaviour
{
    [SerializeField] private Spell spellToCast;

    //[SerializeField] private float maxMana = 100f;
    //[SerializeField] private float currentMana;
    public float maxMana = 100f;
    public float currentMana;

    public healthSlider manaBar;

    [SerializeField] private float manaRechargeRate = 2f;

    [SerializeField] private float timeBetweenCasts = 0.25f;
    private float currentCastTimer;

    [SerializeField] private float timeToWaitforRecharge = 1f;
    private float currentManaRechargeTimer;

    [SerializeField] private Transform castPoint;

    private bool castingMagic = false;

    private PlayerInput playerInput;

    // Start is called before the first frame update
    private void Awake()
    {
        playerInput = new PlayerInput();
        currentMana = maxMana;
        manaBar.setMax(maxMana);
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        manaBar.CurrentHealth(currentMana);
        bool isSpellCastHeldDown = playerInput.ground.SpellCast.ReadValue<float>() > 0.1;
        bool hasEnoughMana = currentMana - spellToCast.SpellToCast.ManaCost >= 0f;

        if(!castingMagic && isSpellCastHeldDown && hasEnoughMana)
        {
            castingMagic = true;
            currentMana -= spellToCast.SpellToCast.ManaCost;

            currentCastTimer = 0;
            currentManaRechargeTimer = 0;

            CastSpell();
        }
        if(castingMagic)
        {
            currentCastTimer += Time.deltaTime;
            if(currentCastTimer > timeBetweenCasts)
            {
                castingMagic = false;
            }
        }

        if(currentMana < maxMana && !castingMagic && !isSpellCastHeldDown)
        {
            currentManaRechargeTimer += Time.deltaTime;

            if(currentManaRechargeTimer > timeToWaitforRecharge)
            {
                currentMana += manaRechargeRate * Time.deltaTime;

                if (currentMana > maxMana)
                {
                    currentMana = maxMana;
                }
            }

        }
    }

    void CastSpell()
    {
        Instantiate(spellToCast, castPoint.position, castPoint.rotation);
    }
}
