// <auto-generated/>
#pragma warning disable CS0618
using Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search.Repositories;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search
{
    /// <summary>
    /// Builds and executes requests for operations under \search
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class SearchRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The repositories property</summary>
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search.Repositories.RepositoriesRequestBuilder Repositories
        {
            get => new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search.Repositories.RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search.SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search.SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
