// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public class AuthenticateRequestParameters : RequestParameters<AuthenticateRequestParameters>
    {
    }

    public class ChangePasswordRequestParameters : RequestParameters<ChangePasswordRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class ClearCachedRealmsRequestParameters : RequestParameters<ClearCachedRealmsRequestParameters>
    {
    }

    public class ClearCachedRolesRequestParameters : RequestParameters<ClearCachedRolesRequestParameters>
    {
    }

    public class CreateApiKeyRequestParameters : RequestParameters<CreateApiKeyRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class DeletePrivilegesRequestParameters : RequestParameters<DeletePrivilegesRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class DeleteRoleRequestParameters : RequestParameters<DeleteRoleRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class DeleteRoleMappingRequestParameters : RequestParameters<DeleteRoleMappingRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class DeleteUserRequestParameters : RequestParameters<DeleteUserRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class DisableUserRequestParameters : RequestParameters<DisableUserRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class EnableUserRequestParameters : RequestParameters<EnableUserRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class GetApiKeyRequestParameters : RequestParameters<GetApiKeyRequestParameters>
    {
        public string? Id { get => Q<string?>("id"); set => Q("id", value); }

        public string? Name { get => Q<string?>("name"); set => Q("name", value); }

        public bool? Owner { get => Q<bool?>("owner"); set => Q("owner", value); }

        public string? RealmName { get => Q<string?>("realm_name"); set => Q("realm_name", value); }

        public string? Username { get => Q<string?>("username"); set => Q("username", value); }
    }

    public class GetBuiltinPrivilegesRequestParameters : RequestParameters<GetBuiltinPrivilegesRequestParameters>
    {
    }

    public class GetPrivilegesRequestParameters : RequestParameters<GetPrivilegesRequestParameters>
    {
    }

    public class GetRoleRequestParameters : RequestParameters<GetRoleRequestParameters>
    {
    }

    public class GetRoleMappingRequestParameters : RequestParameters<GetRoleMappingRequestParameters>
    {
    }

    public class GetUserAccessTokenRequestParameters : RequestParameters<GetUserAccessTokenRequestParameters>
    {
    }

    public class GetUserRequestParameters : RequestParameters<GetUserRequestParameters>
    {
    }

    public class GetUserPrivilegesRequestParameters : RequestParameters<GetUserPrivilegesRequestParameters>
    {
    }

    public class HasPrivilegesRequestParameters : RequestParameters<HasPrivilegesRequestParameters>
    {
    }

    public class InvalidateApiKeyRequestParameters : RequestParameters<InvalidateApiKeyRequestParameters>
    {
    }

    public class InvalidateUserAccessTokenRequestParameters : RequestParameters<InvalidateUserAccessTokenRequestParameters>
    {
    }

    public class PutPrivilegesRequestParameters : RequestParameters<PutPrivilegesRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class PutRoleRequestParameters : RequestParameters<PutRoleRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class PutRoleMappingRequestParameters : RequestParameters<PutRoleMappingRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class PutUserRequestParameters : RequestParameters<PutUserRequestParameters>
    {
        public Refresh? Refresh { get => Q<Refresh?>("refresh"); set => Q("refresh", value); }
    }

    public class GetCertificatesRequestParameters : RequestParameters<GetCertificatesRequestParameters>
    {
    }
}