namespace LibLiveVpn_Contracts.Events
{
    public record WorkerStartedEvent
    {
        public string WorkerId { get; init; } = null!;
    }
}
