using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using static JumpCloud.SDK.V1.Runtime.PowerShell.PsHelpers;

namespace JumpCloud.SDK.V1.Runtime.PowerShell
{
    [Cmdlet(VerbsData.Export, "Psd1")]
    [DoNotExport]
    public class ExportPsd1 : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ExportsFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string CustomFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Psd1Path { get; set; }

        [Parameter(Mandatory = true)]
        public Guid ModuleGuid { get; set; }

        private static readonly bool IsAzure = Convert.ToBoolean(@"false");
        private const string CustomFolderRelative = "./custom";
        private const string Indent = Psd1Indent;

        protected override void ProcessRecord()
        {
            if (!Directory.Exists(ExportsFolder))
            {
                throw new ArgumentException($"Exports folder '{ExportsFolder}' does not exist");
            }

            if (!Directory.Exists(CustomFolder))
            {
                throw new ArgumentException($"Custom folder '{CustomFolder}' does not exist");
            }

            var sb = new StringBuilder();
            sb.AppendLine("@{");
            sb.AppendLine($@"{GuidStart} = '{ModuleGuid}'");
            sb.AppendLine($@"{Indent}RootModule = '{"./JumpCloud.SDK.V1.psm1"}'");
            sb.AppendLine($@"{Indent}ModuleVersion = '{"0.0.1"}'");
            sb.AppendLine($@"{Indent}CompatiblePSEditions = 'Core', 'Desktop'");
            sb.AppendLine($@"{Indent}Author = '{"JumpCloud Solutions Architect Team"}'");
            sb.AppendLine($@"{Indent}CompanyName = '{"JumpCloud"}'");
            sb.AppendLine($@"{Indent}Copyright = '{"(c) JumpCloud. All rights reserved."}'");
            sb.AppendLine($@"{Indent}Description = '{"The JumpCloud PowerShell SDK"}'");
            sb.AppendLine($@"{Indent}PowerShellVersion = '5.1'");
            sb.AppendLine($@"{Indent}DotNetFrameworkVersion = '4.7.2'");
            sb.AppendLine($@"{Indent}RequiredAssemblies = '{"./bin/JumpCloud.SDK.V1.private.dll"}'");

            var customFormatPs1xmlFiles = Directory.GetFiles(CustomFolder)
                .Where(f => f.EndsWith(".format.ps1xml"))
                .Select(f => $"{CustomFolderRelative}/{Path.GetFileName(f)}");
            var formatList = customFormatPs1xmlFiles.Prepend("./JumpCloud.SDK.V1.format.ps1xml").ToPsList();
            sb.AppendLine($@"{Indent}FormatsToProcess = {formatList}");

            var functionInfos = GetScriptCmdlets(ExportsFolder).ToArray();
            var cmdletsList = functionInfos.Select(fi => fi.Name).Distinct().Append("*").ToPsList();
            sb.AppendLine($@"{Indent}CmdletsToExport = {cmdletsList}");
            var aliasesList = functionInfos.SelectMany(fi => fi.ScriptBlock.Attributes).ToAliasNames().Append("*").ToPsList();
            sb.AppendLine($@"{Indent}AliasesToExport = {aliasesList}");

            sb.AppendLine($@"{Indent}PrivateData = @{{");
            sb.AppendLine($@"{Indent}{Indent}PSData = @{{");

            sb.AppendLine($@"{Indent}{Indent}{Indent}Tags = {"JumpCloud, DaaS, Jump, Cloud, Directory".Split(' ').ToPsList().NullIfEmpty() ?? "''"}");
            sb.AppendLine($@"{Indent}{Indent}{Indent}LicenseUri = '{"https://github.com/TheJumpCloud/support/blob/master/PowerShell/LICENSE"}'");
            sb.AppendLine($@"{Indent}{Indent}{Indent}ProjectUri = '{"https://github.com/TheJumpCloud/support/wiki"}'");
            sb.AppendLine($@"{Indent}{Indent}{Indent}ReleaseNotes = ''");
            var profilesList = "";
            if (IsAzure && !String.IsNullOrEmpty(profilesList))
            {
                sb.AppendLine($@"{Indent}{Indent}{Indent}Profiles = {profilesList}");
            }

            sb.AppendLine($@"{Indent}{Indent}}}");
            sb.AppendLine($@"{Indent}}}");
            sb.AppendLine(@"}");

            File.WriteAllText(Psd1Path, sb.ToString());
        }
    }
}
