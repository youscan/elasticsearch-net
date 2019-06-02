// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.TasksApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>descriptor for Cancel <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</pre></summary>
	public partial class CancelTasksDescriptor : RequestDescriptorBase<CancelTasksDescriptor, CancelTasksRequestParameters, ICancelTasksRequest>, ICancelTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksCancel;
		///<summary>/_tasks/_cancel</summary>
		public CancelTasksDescriptor(): base()
		{
		}

		///<summary>/_tasks/{task_id}/_cancel</summary>
		///<param name = "taskId">Optional, accepts null</param>
		public CancelTasksDescriptor(TaskId taskId): base(r => r.Optional("task_id", taskId))
		{
		}

		// values part of the url path
		TaskId ICancelTasksRequest.TaskId => Self.RouteValues.Get<TaskId>("task_id");
		///<summary>Cancel the task with specified task id (node_id:task_number)</summary>
		public CancelTasksDescriptor TaskId(TaskId taskId) => Assign(taskId, (a, v) => a.RouteValues.Optional("task_id", v));
		// Request parameters
		///<summary>A comma-separated list of actions that should be cancelled. Leave empty to cancel all.</summary>
		public CancelTasksDescriptor Actions(params string[] actions) => Qs("actions", actions);
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public CancelTasksDescriptor Nodes(params string[] nodes) => Qs("nodes", nodes);
		///<summary>Cancel tasks with specified parent task id (node_id:task_number). Set to -1 to cancel all.</summary>
		public CancelTasksDescriptor ParentTaskId(string parenttaskid) => Qs("parent_task_id", parenttaskid);
	}

	///<summary>descriptor for GetTask <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</pre></summary>
	public partial class GetTaskDescriptor : RequestDescriptorBase<GetTaskDescriptor, GetTaskRequestParameters, IGetTaskRequest>, IGetTaskRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksGetTask;
		///<summary>/_tasks/{task_id}</summary>
		///<param name = "taskId">this parameter is required</param>
		public GetTaskDescriptor(TaskId taskId): base(r => r.Required("task_id", taskId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetTaskDescriptor(): base()
		{
		}

		// values part of the url path
		TaskId IGetTaskRequest.TaskId => Self.RouteValues.Get<TaskId>("task_id");
		// Request parameters
		///<summary>Explicit operation timeout</summary>
		public GetTaskDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public GetTaskDescriptor WaitForCompletion(bool? waitforcompletion = true) => Qs("wait_for_completion", waitforcompletion);
	}

	///<summary>descriptor for List <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</pre></summary>
	public partial class ListTasksDescriptor : RequestDescriptorBase<ListTasksDescriptor, ListTasksRequestParameters, IListTasksRequest>, IListTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksList;
		// values part of the url path
		// Request parameters
		///<summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
		public ListTasksDescriptor Actions(params string[] actions) => Qs("actions", actions);
		///<summary>Return detailed task information (default: false)</summary>
		public ListTasksDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
		///<summary>Group tasks by nodes or parent/child relationships</summary>
		public ListTasksDescriptor GroupBy(GroupBy? groupby) => Qs("group_by", groupby);
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public ListTasksDescriptor Nodes(params string[] nodes) => Qs("nodes", nodes);
		///<summary>Return tasks with specified parent task id (node_id:task_number). Set to -1 to return all.</summary>
		public ListTasksDescriptor ParentTaskId(string parenttaskid) => Qs("parent_task_id", parenttaskid);
		///<summary>Explicit operation timeout</summary>
		public ListTasksDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public ListTasksDescriptor WaitForCompletion(bool? waitforcompletion = true) => Qs("wait_for_completion", waitforcompletion);
	}
}