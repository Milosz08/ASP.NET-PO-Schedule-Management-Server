﻿using ScheduleManagement.Api.Db;
using ScheduleManagement.Api.Dto;

namespace ScheduleManagement.Api.Network.Helper;

public interface IHelperService
{
	List<int> GetAvailablePaginationTypes();

	Task<AvailableDataResponseDto<NameIdElementDto>> GetAvailableStudyTypes();

	Task<AvailableDataResponseDto<NameIdElementDto>> GetAvailableStudyDegreeTypes();

	Task<AvailableDataResponseDto<NameIdElementDto>> GetAvailableSemesters();

	Task<List<NameIdElementDto>> GetAvailableStudyDegreeBaseAllSpecs(long deptId);

	Task<List<NameIdElementDto>> GetAvailableSemBaseStudyGroups(long deptId, long studySpecId);

	Task<ConvertToNameWithIdResponseDto> ConvertNamesToIds(ConvertNamesToIdsRequestDto dto);

	Task<ConvertToNameWithIdResponseDto> ConvertIdsToNames(ConvertIdsToNamesRequestDto dto);

	Task<AvailableDataResponseDto<string>> GetAvailableSubjectTypes(string? subjTypeName);

	Task<AvailableDataResponseDto<string>> GetAvailableRoomTypes();

	Task<AvailableDataResponseDto<string>> GetAvailableRoles();
}
