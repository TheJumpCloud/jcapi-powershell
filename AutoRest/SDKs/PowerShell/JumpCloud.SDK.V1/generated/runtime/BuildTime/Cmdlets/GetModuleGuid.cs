using System.Management.Automation;
using static JumpCloud.SDK.V1.Runtime.PowerShell.PsHelpers;

namespace JumpCloud.SDK.V1.Runtime.PowerShell
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
