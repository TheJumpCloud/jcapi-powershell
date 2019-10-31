﻿using System.Linq;
using System.Management.Automation;
using static JumpCloudApiSdkV1.Runtime.PowerShell.PsHelpers;

namespace JumpCloudApiSdkV1.Runtime.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "ScriptCmdlet")]
    [OutputType(typeof(string[]))]
    [DoNotExport]
    public class GetScriptCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ScriptFolder { get; set; }

        [Parameter]
        public SwitchParameter IncludeDoNotExport { get; set; }

        [Parameter]
        public SwitchParameter AsAlias { get; set; }

        [Parameter]
        public SwitchParameter AsFunctionInfo { get; set; }

        protected override void ProcessRecord()
        {
            var functionInfos = GetScriptCmdlets(this, ScriptFolder)
                .Where(fi => IncludeDoNotExport || !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
                .ToArray();
            if (AsFunctionInfo)
            {
                WriteObject(functionInfos, true);
                return;
            }
            var aliases = functionInfos.SelectMany(i => i.ScriptBlock.Attributes).ToAliasNames();
            var names = functionInfos.Select(fi => fi.Name).Distinct();
            var output = (AsAlias ? aliases : names).DefaultIfEmpty("''").ToArray();
            WriteObject(output, true);
        }
    }
}
