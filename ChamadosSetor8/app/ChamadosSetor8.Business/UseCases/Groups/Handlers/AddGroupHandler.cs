﻿using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Groups.Commands;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Handlers
{
    public class AddGroupHandler : IRequestHandler<AddGroupCommand, ApiResult<Group>>
    {
        private readonly IGroupRepository _groupRepository;

        public AddGroupHandler(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<ApiResult<Group>> Handle(AddGroupCommand command, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<Group>();

            apiResult.SetData(await _groupRepository.AddAsync(command));

            await _groupRepository.SaveAsync();

            return apiResult;

        }
    }
}
