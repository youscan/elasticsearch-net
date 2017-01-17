﻿using Newtonsoft.Json;

namespace Nest252
{
	public interface ISnapshotRepository
	{
		[JsonProperty("type")]
		string Type { get; }
	}

	public interface IRepository<TSettings> : ISnapshotRepository
		where TSettings : class, IRepositorySettings
	{
		[JsonProperty("settings")]
		TSettings Settings { get; set; }
	}

	public interface IRepositorySettings { }
}