using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagicSystem : MonoBehaviour
{
    [SerializeField] private Spell spellToCast;

    [SerializeField] private float maxMana = 100f;
    [SerializeField] private float currentMana;
    [SerializeField] private float manaRechargeRate = 2f;
    [SerializeField] private float timeBetweenCasts = 0.25f;
    private float currentCastTimer;

    [SerializeField] private Transform castPoint;

    private bool castingMagic = false;

    private PlayerInput playerControls;

    // Start is called before the first frame update
    private void Awake()
    {
        playerControls = new PlayerInput();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        bool isSpellCastHeldDown = playerControls.Controls.SpellCast.ReadValue<float>() > 0.1;

        if(!castingMagic && isSpellCastHeldDown)
        {
            castingMagic = true;
            currentCastTimer = 0;
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
    }

    void CastSpell()
    {
        Instantiate(spellToCast, castPoint.position, castPoint.rotation);
    }
}
