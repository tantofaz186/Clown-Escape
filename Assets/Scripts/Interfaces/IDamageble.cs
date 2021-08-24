namespace Interfaces
{
    public interface IDamageble
    {
        bool isDead { get;}
        void TakeDamage(int damage = 1);
        void Die();
    }
}