﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System.IO;

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using Authentication;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;

    /// <summary>
    /// Provides methods for getting attachments from messages and uploading attachments to streams, by
    /// encapsulating <see cref="Generated.OpenApi.AgentApi.Api.AttachmentsApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class AttachmentsApi
    {
        private readonly Generated.OpenApi.AgentApi.Api.AttachmentsApi _attachmentsApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public AttachmentsApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _attachmentsApi = new Generated.OpenApi.AgentApi.Api.AttachmentsApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Uploads an attachment to an existing stream. After the attachment is uploaded it can
        /// be used on a message in that stream.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="file">The file to upload as an attachment.</param>
        /// <returns>Attachment info.</returns>
        public AttachmentInfo UploadAttachment(string sid, Stream file)
        {
            return _apiExecutor.Execute(_attachmentsApi.V1StreamSidAttachmentCreatePost, sid, _authTokens.SessionToken, _authTokens.KeyManagerToken, file);
        }

        /// <summary>
        /// Downloads an attachment from a message.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="messageId">The ID of the message containing the attachment.</param>
        /// <param name="fileId">Attachment ID.</param>
        /// <returns>The contents of the attached file.</returns>
        public byte[] DownloadAttachment(string sid, string messageId, string fileId)
        {
            return _apiExecutor.Execute(_attachmentsApi.V1StreamSidAttachmentGet, sid, fileId, messageId, _authTokens.SessionToken, _authTokens.KeyManagerToken);
        }
    }
}