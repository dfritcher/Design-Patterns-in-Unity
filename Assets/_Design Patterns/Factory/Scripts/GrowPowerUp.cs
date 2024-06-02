using UnityEngine;
public class GrowPowerUp : MonoBehaviour , IPowerUp
{
    private string _name;
    private Animator _animator;
    public string Name { get { return _name; } set { _name = value; } }


    public void Initialize()
    {
        _animator = GetComponent<Animator>();
        _animator.SetTrigger("Grow");
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void Pickup()
    {        
        _animator.SetTrigger("Disable");
        gameObject.SetActive(false);
    }   
}