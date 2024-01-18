using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamadosSetor8.Business.Common;

namespace ChamadosSetor8.Business.UseCases.Users.GetAll;

public class GetAllHandler : IRequestHandler<GetAllQuery, ApiResult<IEnumerable<User>>>
{
    private readonly IUserRepository _userRepository;
    public GetAllHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApiResult<IEnumerable<User>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var apiResult = new ApiResult<IEnumerable<User>>();

        return apiResult.SetData(await _userRepository.GetAllAsync());
    }
}
