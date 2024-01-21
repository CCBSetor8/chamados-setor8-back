using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Users.GetById;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Users.Add;

public class AddHandler : IRequestHandler<AddCommand, ApiResult<User>>
{
    private readonly IUserRepository _userRepository;
    public AddHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApiResult<User>> Handle(AddCommand command, CancellationToken cancellationToken)
    {
        var apiResult = new ApiResult<User>();
        var user = (User)command;

        return apiResult.SetData(await _userRepository.AddAsync(user));
    }
}
