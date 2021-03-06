using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessageSuppressionApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Suppress a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>MessageSuppressionResponse</returns>
        MessageSuppressionResponse V1AdminMessagesuppressionIdSuppressPost (string id, string sessionToken);

        /// <summary>
        /// Suppress a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of MessageSuppressionResponse</returns>
        ApiResponse<MessageSuppressionResponse> V1AdminMessagesuppressionIdSuppressPostWithHttpInfo (string id, string sessionToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Suppress a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of MessageSuppressionResponse</returns>
        System.Threading.Tasks.Task<MessageSuppressionResponse> V1AdminMessagesuppressionIdSuppressPostAsync (string id, string sessionToken);

        /// <summary>
        /// Suppress a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (MessageSuppressionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageSuppressionResponse>> V1AdminMessagesuppressionIdSuppressPostAsyncWithHttpInfo (string id, string sessionToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MessageSuppressionApi : IMessageSuppressionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSuppressionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessageSuppressionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSuppressionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessageSuppressionApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Suppress a message 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>MessageSuppressionResponse</returns>
        public MessageSuppressionResponse V1AdminMessagesuppressionIdSuppressPost (string id, string sessionToken)
        {
             ApiResponse<MessageSuppressionResponse> localVarResponse = V1AdminMessagesuppressionIdSuppressPostWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Suppress a message 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of MessageSuppressionResponse</returns>
        public ApiResponse< MessageSuppressionResponse > V1AdminMessagesuppressionIdSuppressPostWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MessageSuppressionApi->V1AdminMessagesuppressionIdSuppressPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessageSuppressionApi->V1AdminMessagesuppressionIdSuppressPost");

            var localVarPath = "/v1/admin/messagesuppression/{id}/suppress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminMessagesuppressionIdSuppressPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminMessagesuppressionIdSuppressPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageSuppressionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageSuppressionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageSuppressionResponse)));
            
        }

        /// <summary>
        /// Suppress a message 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of MessageSuppressionResponse</returns>
        public async System.Threading.Tasks.Task<MessageSuppressionResponse> V1AdminMessagesuppressionIdSuppressPostAsync (string id, string sessionToken)
        {
             ApiResponse<MessageSuppressionResponse> localVarResponse = await V1AdminMessagesuppressionIdSuppressPostAsyncWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Suppress a message 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">URL-Safe encoded Message ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (MessageSuppressionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageSuppressionResponse>> V1AdminMessagesuppressionIdSuppressPostAsyncWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MessageSuppressionApi->V1AdminMessagesuppressionIdSuppressPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessageSuppressionApi->V1AdminMessagesuppressionIdSuppressPost");

            var localVarPath = "/v1/admin/messagesuppression/{id}/suppress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminMessagesuppressionIdSuppressPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminMessagesuppressionIdSuppressPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageSuppressionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageSuppressionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageSuppressionResponse)));
            
        }

    }
}
