namespace JumpCloudApiSdkV2
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>A class that contains the module-common code and data.</summary>
    public partial class Module
    {
        /// <summary>FIXME: Field _handler is MISSING DESCRIPTION</summary>
        public global::System.Net.Http.HttpClientHandler _handler = new global::System.Net.Http.HttpClientHandler();

        /// <summary>the ISendAsync pipeline instance</summary>
        private JumpCloudApiSdkV2.Runtime.HttpPipeline _pipeline;

        /// <summary>the ISendAsync pipeline instance (when proxy is enabled)</summary>
        private JumpCloudApiSdkV2.Runtime.HttpPipeline _pipelineWithProxy;

        /// <summary>FIXME: Field _webProxy is MISSING DESCRIPTION</summary>
        public global::System.Net.WebProxy _webProxy = new global::System.Net.WebProxy();

        /// <summary>The instance of the Client API</summary>
        public JumpCloudApiSdkV2.JumpCloudApIs ClientAPI { get; set; }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private static JumpCloudApiSdkV2.Module _instance;

        /// <summary>the singleton of this module class</summary>
        public static JumpCloudApiSdkV2.Module Instance => JumpCloudApiSdkV2.Module._instance?? (JumpCloudApiSdkV2.Module._instance = new JumpCloudApiSdkV2.Module());

        /// <summary>The Name of this module</summary>
        public string Name => @"JumpCloudApiSdkV2";

        /// <summary>FIXME: Method AfterCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>

        partial void AfterCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref JumpCloudApiSdkV2.Runtime.HttpPipeline pipeline);

        /// <summary>FIXME: Method BeforeCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>

        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref JumpCloudApiSdkV2.Runtime.HttpPipeline pipeline);

        /// <summary>FIXME: Method CustomInit is MISSING DESCRIPTION</summary>

        partial void CustomInit();

        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <returns>An instance of JumpCloudApiSdkV2.Runtime.HttpPipeline for the remote call.</returns>
        public JumpCloudApiSdkV2.Runtime.HttpPipeline CreatePipeline(System.Management.Automation.InvocationInfo invocationInfo)
        {
            JumpCloudApiSdkV2.Runtime.HttpPipeline pipeline = null;
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
            ClientAPI = new JumpCloudApiSdkV2.JumpCloudApIs();
            _handler.Proxy = _webProxy;
            _pipeline = new JumpCloudApiSdkV2.Runtime.HttpPipeline(new JumpCloudApiSdkV2.Runtime.HttpClientFactory(new global::System.Net.Http.HttpClient()));
            _pipelineWithProxy = new JumpCloudApiSdkV2.Runtime.HttpPipeline(new JumpCloudApiSdkV2.Runtime.HttpClientFactory(new global::System.Net.Http.HttpClient(_handler)));
        }

        /// <summary>FIXME: Method SetProxyConfiguration is MISSING DESCRIPTION</summary>
        /// <param name="proxy">The HTTP Proxy to use.</param>
        /// <param name="proxyCredential">The HTTP Proxy Credentials</param>
        /// <param name="proxyUseDefaultCredentials">True if the proxy should use default credentials</param>
        public void SetProxyConfiguration(global::System.Uri proxy, System.Management.Automation.PSCredential proxyCredential, bool proxyUseDefaultCredentials)
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