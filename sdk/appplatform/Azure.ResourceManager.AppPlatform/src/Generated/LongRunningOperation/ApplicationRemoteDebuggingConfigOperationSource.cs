// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    internal class ApplicationRemoteDebuggingConfigOperationSource : IOperationSource<ApplicationRemoteDebuggingConfig>
    {
        ApplicationRemoteDebuggingConfig IOperationSource<ApplicationRemoteDebuggingConfig>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return ApplicationRemoteDebuggingConfig.DeserializeApplicationRemoteDebuggingConfig(document.RootElement);
        }

        async ValueTask<ApplicationRemoteDebuggingConfig> IOperationSource<ApplicationRemoteDebuggingConfig>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return ApplicationRemoteDebuggingConfig.DeserializeApplicationRemoteDebuggingConfig(document.RootElement);
        }
    }
}
