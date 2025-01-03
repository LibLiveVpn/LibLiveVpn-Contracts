namespace LibLiveVpn_Contracts.Commands
{
    public record CreateInterfaceCommand
    {
        public string InterfaceName { get; init; } = null!;

        public string Configuration { get; init; } = null!;
    }
}
