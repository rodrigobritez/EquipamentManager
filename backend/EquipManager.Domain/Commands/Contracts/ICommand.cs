namespace EquipManager.Domain.Commands.Contracts
{
    public interface ICommand
    {
        bool Validate();
    }
}