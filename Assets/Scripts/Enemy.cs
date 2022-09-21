using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    public int curHealth;
    public Transform target;
    public BoxCollider meleeArea;
    public bool isChase;
    public bool isAttack;
    public int atkCnt = 0; // 점수가 한 번만 오르게 감시하는 변수

    public GameDirector manager;
    public AudioSource damageSound;

    Rigidbody rigid;
    BoxCollider boxCollider;
    Material mat;
    NavMeshAgent nav;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        mat = GetComponentInChildren<MeshRenderer>().material;
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();

        Invoke("ChaseStart", 2);
    }
    void ChaseStart()
    {
        isChase = true;
        anim.SetBool("isWalk", true);
    }
    void Update()
    {
        if(nav.enabled){
            nav.SetDestination(target.position);
            nav.isStopped = !isChase;
            if(nav.speed < 10){ // 최고속도는 10으로 정한다.
                nav.speed = manager.stage * 2; //현재 게임의 스테이지 상황에 따라 플레이어를 따라가는 속도가 달라진다. 
            }
        }      
    }

    void FreezeVelocity()
    {
        if(isChase){
            rigid.velocity = Vector3.zero;
            rigid.angularVelocity = Vector3.zero;
        }
    
    }
    
    void Targerting()
    {
        float targetRadius = 1.5f;
        float targetRange = 3f;

        RaycastHit[] rayHits = 
            Physics.SphereCastAll(transform.position,
                                targetRadius,
                                transform.forward, 
                                targetRange,
                                LayerMask.GetMask("Player"));
        if(rayHits.Length > 0 && !isAttack) {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        isChase = false;
        isAttack = true;
        anim.SetBool("isAttack", true);
        
        yield return new WaitForSeconds(0.2f); //바로 공격하지 못하게 지연시간을 줌
        meleeArea.enabled = true;

        yield return new WaitForSeconds(1f);
        meleeArea.enabled = false;

        yield return new WaitForSeconds(1f);
        
        isChase = true;
        isAttack = false;
        anim.SetBool("isAttack", false);

    }

    void FixedUpdate()
    {
        Targerting();
        FreezeVelocity();
    }
    void OnTriggerEnter(Collider coll) 
    {
        if(coll.tag == "Bullet")
        {
            Bullet bullet = coll.GetComponent<Bullet>();
            curHealth -= bullet.damage;
            Vector3 reactVec = transform.position - coll.transform.position;
            Destroy(coll.gameObject);
            StartCoroutine(OnDamage(reactVec));
        }
    }

    IEnumerator OnDamage(Vector3 reactVec)
    {
        mat.color = Color.red;
        damageSound.Play();
        if(curHealth > 0){
            mat.color = Color.white;
            reactVec = reactVec.normalized;
            reactVec += Vector3.up;
            rigid.AddForce(reactVec * 2, ForceMode.Impulse);

        }else{
            Destroy(gameObject, 1);
            mat.color = Color.gray;
            isChase = false;
            nav.enabled = false;
            anim.SetTrigger("doDie");
            
            if(atkCnt < 1){ // 점수가 한 번만 오르게 하는 변수를 이용해서 hp가 0이 되면 한 번만 스코어를 올려준다.
                manager.enemyCnt--; //적이 죽으면 적의 수를 하나 줄여준다.
                manager.ScoreUp();// 적을 죽이면 스코어업 함수를 실행해서 스코어를 올려준다.
            }
            atkCnt++;
        }
        yield return null;
    }
}
