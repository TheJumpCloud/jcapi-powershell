using System.Management.Automation;
using static JumpCloudApiSdkV2.Runtime.PowerShell.PsHelpers;

namespace JumpCloudApiSdkV2.Runtime.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "ModuleGuid")]
    [DoNotExport]
    public class GetModuleGuid : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Psd1Path { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(ReadGuidFromPsd1(Psd1Path));
        }
    }
}
