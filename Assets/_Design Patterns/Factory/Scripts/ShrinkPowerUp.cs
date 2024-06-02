using UnityEngine;
public class ShrinkPowerUp : MonoBehaviour , IPowerUp
{
    private string _name;
    private Animator _animator;
    public string Name { get { return _name; } set { _name = value; } }


    public void Initialize()
    {
        _animator = GetComponent<Animator>();
        _animator.SetTrigger("Shrink");
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void Pickup()
    {
        gameObject.SetActive(false);
        _animator.SetTrigger("Disable");
    }
}