// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>A class that contains the module-common code and data.</summary>
    public partial class Module
    {
        public global::System.Net.Http.HttpClientHandler _handler = new global::System.Net.Http.HttpClientHandler();

        /// <summary>the ISendAsync pipeline instance</summary>
        private JumpCloud.SDK.V1.Runtime.HttpPipeline _pipeline;

        /// <summary>the ISendAsync pipeline instance (when proxy is enabled)</summary>
        private JumpCloud.SDK.V1.Runtime.HttpPipeline _pipelineWithProxy;

        public global::System.Net.WebProxy _webProxy = new global::System.Net.WebProxy();

        /// <summary>The instance of the Client API</summary>
        public JumpCloud.SDK.V1.JumpCloudApIs ClientAPI { get; set; }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private static JumpCloud.SDK.V1.Module _instance;

        /// <summary>the singleton of this module class</summary>
        public static JumpCloud.SDK.V1.Module Instance => JumpCloud.SDK.V1.Module._instance?? (JumpCloud.SDK.V1.Module._instance = new JumpCloud.SDK.V1.Module());

        /// <summary>The Name of this module</summary>
        public string Name => @"JumpCloud.SDK.V1";

        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>

        partial void AfterCreatePipeline(global::System.Management.Automation.InvocationInfo invocationInfo, ref JumpCloud.SDK.V1.Runtime.HttpPipeline pipeline);

        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>

        partial void BeforeCreatePipeline(global::System.Management.Automation.InvocationInfo invocationInfo, ref JumpCloud.SDK.V1.Runtime.HttpPipeline pipeline);

        partial void CustomInit();

        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="parameterSetName">the cmdlet's parameterset name.</param>
        /// <returns>An instance of JumpCloud.SDK.V1.Runtime.HttpPipeline for the remote call.</returns>
        public JumpCloud.SDK.V1.Runtime.HttpPipeline CreatePipeline(global::System.Management.Automation.InvocationInfo invocationInfo, string parameterSetName = null)
        {
            JumpCloud.SDK.V1.Runtime.HttpPipeline pipeline = null;
            BeforeCreatePipeline(invocationInfo, ref pipeline);
            pipeline = (pipeline ?? (_handler.UseProxy ? _pipelineWithProxy : _pipeline)).Clone();
            AfterCreatePipeline(invocationInfo, ref pipeline);
            return pipeline;
        }

        /// <summary>Initialization steps performed after the module is loaded.</summary>
        public void Init()
        {
            // called at module init time...
            CustomInit();
        }

        /// <summary>Creates the module instance.</summary>
        private Module()
        {
            /// constructor
            ClientAPI = new JumpCloud.SDK.V1.JumpCloudApIs();
            _handler.Proxy = _webProxy;
            _pipeline = new JumpCloud.SDK.V1.Runtime.HttpPipeline(new JumpCloud.SDK.V1.Runtime.HttpClientFactory(new global::System.Net.Http.HttpClient()));
            _pipelineWithProxy = new JumpCloud.SDK.V1.Runtime.HttpPipeline(new JumpCloud.SDK.V1.Runtime.HttpClientFactory(new global::System.Net.Http.HttpClient(_handler)));
        }

        /// <param name="proxy">The HTTP Proxy to use.</param>
        /// <param name="proxyCredential">The HTTP Proxy Credentials</param>
        /// <param name="proxyUseDefaultCredentials">True if the proxy should use default credentials</param>
        public void SetProxyConfiguration(global::System.Uri proxy, global::System.Management.Automation.PSCredential proxyCredential, bool proxyUseDefaultCredentials)
        {
            // set the proxy configuration
            _webProxy.Address = proxy;
            _webProxy.BypassProxyOnLocal = false;
            _webProxy.Credentials = proxyCredential ?.GetNetworkCredential();
            _webProxy.UseDefaultCredentials = proxyUseDefaultCredentials;
            _handler.UseProxy = proxy != null;
        }
    }
}