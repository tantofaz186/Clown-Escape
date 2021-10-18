namespace Interfaces
{
    public interface IJumper
    {
        void Jump();
        bool isGrounded { get; }
    }
}