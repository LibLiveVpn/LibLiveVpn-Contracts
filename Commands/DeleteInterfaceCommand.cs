namespace LibLiveVpn_Contracts.Commands
{
    public record DeleteInterfaceCommand
    {
        public string InterfaceName { get; init; } = null!;
    }
}
