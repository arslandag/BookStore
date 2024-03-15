namespace BookStore.Api.Contracts
{
    public record BookRequest(
       string Title,
       string Description,
       decimal Price);
}