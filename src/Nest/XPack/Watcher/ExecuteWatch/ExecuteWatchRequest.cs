﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public partial interface IExecuteWatchRequest
	{
		/// <summary>
		/// This structure will be parsed as a trigger event and used for the watch execution.
		/// </summary>
		[JsonProperty("trigger_data")]
		IScheduleTriggerEvent TriggerData { get; set; }

		/// <summary>
		/// If this is set to true the watch execution will use the Always Condition.
		/// </summary>
		[JsonProperty("ignore_condition")]
		bool? IgnoreCondition { get; set; }

		/// <summary>
		/// If this is set to true the WatchRecord generated by executing the watch will be persisted
		/// to the .watcher_history index for the current time.
		/// Also the status of the watch is updated,
		/// possbily throttling subsequent executions.
		/// </summary>
		[JsonProperty("record_execution")]
		bool? RecordExecution { get; set; }

		/// <summary>
		/// When present, the watch uses this object as a payload
		/// instead of executing its own input.
		/// </summary>
		[JsonProperty("alternative_input")]
		[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter))]
		IDictionary<string, object> AlternativeInput { get; set; }

		/// <summary>
		/// Determines how to handle the watch actions as part of the watch execution.
		/// </summary>
		[JsonProperty("action_modes")]
		[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter))]
		IDictionary<string, ActionExecutionMode> ActionModes { get; set; }

		/// <summary>
		///This field can either be a list of action ids or the string _all.
		/// If _all is set or an action that is executed by the watch appears in this list
		/// it will be executed in simulated mode.
		/// </summary>
		[JsonProperty("simulated_actions")]
		SimulatedActions SimulatedActions { get; set; }

		/// <summary>
		/// When present, this watch is used instead of the one specified in the request.
		/// This watch is not persisted to the index and record_execution cannot be set.
		/// </summary>
		[JsonProperty("watch")]
		IPutWatchRequest Watch { get; set; }
	}

	public partial class ExecuteWatchRequest
	{
		public IScheduleTriggerEvent TriggerData { get; set; }

		public bool? IgnoreCondition { get; set; }

		public bool? RecordExecution { get; set; }

		public IDictionary<string, object> AlternativeInput { get; set; }

		public IDictionary<string, ActionExecutionMode> ActionModes { get; set; }

		public SimulatedActions SimulatedActions { get; set; }

		public IPutWatchRequest Watch { get; set; }
	}

	[DescriptorFor("WatcherExecuteWatch")]
	public partial class ExecuteWatchDescriptor
	{
		IScheduleTriggerEvent IExecuteWatchRequest.TriggerData { get; set; }
		bool? IExecuteWatchRequest.IgnoreCondition { get; set; }
		bool? IExecuteWatchRequest.RecordExecution { get; set; }
		IDictionary<string, object> IExecuteWatchRequest.AlternativeInput { get; set; }
		IDictionary<string, ActionExecutionMode> IExecuteWatchRequest.ActionModes { get; set; }
		SimulatedActions IExecuteWatchRequest.SimulatedActions { get; set; }
		IPutWatchRequest IExecuteWatchRequest.Watch { get; set; }

		public ExecuteWatchDescriptor TriggerData(Func<ScheduleTriggerEventDescriptor, IScheduleTriggerEvent> selector) =>
			Assign(a => a.TriggerData = selector?.InvokeOrDefault(new ScheduleTriggerEventDescriptor()));

		public ExecuteWatchDescriptor IgnoreCondition(bool ignore = true) =>
			Assign(a => a.IgnoreCondition = ignore);

		public ExecuteWatchDescriptor RecordExecution(bool record = true) =>
			Assign(a => a.RecordExecution = record);

		public ExecuteWatchDescriptor ActionModes(Func<FluentDictionary<string, ActionExecutionMode>, FluentDictionary<string, ActionExecutionMode>> actionModesDictionary) =>
			Assign(a => a.ActionModes = actionModesDictionary(new FluentDictionary<string, ActionExecutionMode>()));

		public ExecuteWatchDescriptor ActionModes(Dictionary<string, ActionExecutionMode> actionModesDictionary) =>
			Assign(a => a.ActionModes = actionModesDictionary);

		public ExecuteWatchDescriptor AlternativeInput(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> alternativeInputDictionary) =>
			Assign(a => a.AlternativeInput = alternativeInputDictionary(new FluentDictionary<string, object>()));

		public ExecuteWatchDescriptor AlternativeInput(Dictionary<string, object> alternativeInputDictionary) =>
			Assign(a => a.AlternativeInput = alternativeInputDictionary);

		public ExecuteWatchDescriptor SimulatedActions(SimulatedActions simulatedActions) =>
			Assign(a => a.SimulatedActions = simulatedActions);

		public ExecuteWatchDescriptor Watch(Func<PutWatchDescriptor, IPutWatchRequest> watch) =>
			Assign(a => a.Watch = watch?.InvokeOrDefault(new PutWatchDescriptor()));
	}
}
