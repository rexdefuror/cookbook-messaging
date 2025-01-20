namespace Cookbook.Contracts.Cooking.StateMachineEvents;

public record RecipeCookingFailed
{
    public Guid CookingRequestId { get; set; }
}