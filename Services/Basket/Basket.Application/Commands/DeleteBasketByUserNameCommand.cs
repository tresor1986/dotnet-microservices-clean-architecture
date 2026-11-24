using MediatR;

namespace Basket.Application.Commands
{
    public record class DeleteBasketByUserNameCommand(string userName):IRequest<Unit>
    {
    }
}
