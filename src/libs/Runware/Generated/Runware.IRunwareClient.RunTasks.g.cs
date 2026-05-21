#nullable enable

namespace Runware
{
    public partial interface IRunwareClient
    {
        /// <summary>
        /// Run one or more Runware tasks<br/>
        /// Runware's REST API accepts a JSON array where each item is a task.<br/>
        /// This endpoint supports authentication by Bearer header; payload-based<br/>
        /// authentication can also be represented by adding an authentication task<br/>
        /// as the first item in the request array.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runware.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runware.RunwareResponse> RunTasksAsync(

            global::System.Collections.Generic.IList<global::Runware.RunwareTask> request,
            global::Runware.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run one or more Runware tasks<br/>
        /// Runware's REST API accepts a JSON array where each item is a task.<br/>
        /// This endpoint supports authentication by Bearer header; payload-based<br/>
        /// authentication can also be represented by adding an authentication task<br/>
        /// as the first item in the request array.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runware.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runware.AutoSDKHttpResponse<global::Runware.RunwareResponse>> RunTasksAsResponseAsync(

            global::System.Collections.Generic.IList<global::Runware.RunwareTask> request,
            global::Runware.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}