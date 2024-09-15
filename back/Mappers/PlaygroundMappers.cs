using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Constants;
using back.DTOs.Playground;
using back.Models;

namespace back.Mappers
{
    public static class PlaygroundMappers
    {
        public static PlaygroundDto ToPlaygroundDto(this Playground playgroundModel)
        {
            return new PlaygroundDto
            {
                Id = playgroundModel.Id,
                Name = playgroundModel.Name,
                Address = playgroundModel.Address,
                Images = playgroundModel.Images
            };
        }

        public static Playground ToPlaygroundFromCreateDto(this CreatePlaygroundDto playgroundDto)
        {
            return new Playground
            {
                Name = playgroundDto.Name,
                Address = playgroundDto.Address,
                Images = playgroundDto.Images,
                RequiredVotesElectModerator = DefaultValues.RequiredVotesElectModerator,
                RequiredVotesDismissModerator = DefaultValues.RequiredVotesDismissModerator,
                RequiredVotesScheduleSession = DefaultValues.RequiredVotesScheduleSession,
                RequiredVotesDiscardSession = DefaultValues.RequiredVotesDiscardSession,
                RequiredVotesEditPlayground = DefaultValues.RequiredVotesEditPlayground,
                RequiredVotesDeletePlayground = DefaultValues.RequiredVotesDeletePlayground,
            };
        }
    }
}