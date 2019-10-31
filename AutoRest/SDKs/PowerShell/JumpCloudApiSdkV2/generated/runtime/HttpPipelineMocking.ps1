$ErrorActionPreference = "Stop"

# get the recording path
if (-not $TestRecordingFile) {
  $TestRecordingFile = Join-Path $PSScriptRoot 'recording.json'
}

# create the Http Pipeline Recorder
$Mock = New-Object -Type JumpCloudApiSdkV2.Runtime.PipelineMock $TestRecordingFile

# set the recorder to the appropriate mode (default to 'live')
Write-Host -ForegroundColor Green "Running '$TestMode' mode..."
switch ($TestMode) {
  'record' {
    Write-Host -ForegroundColor Green "Recording to $TestRecordingFile"
    $Mock.SetRecord()
    $null = erase -ea 0 $TestRecordingFile
  }
  'playback' {
    if (-not (Test-Path $TestRecordingFile)) {
      Write-Error "Recording file '$TestRecordingFile' is not present. Unable to continue in 'playback' mode."
    }
    Write-Host -ForegroundColor Green "Using recording $TestRecordingFile"
    $Mock.SetPlayback()
    $Mock.ForceResponseHeaders["Retry-After"] = "0";
  }
  default: {
    $Mock.SetLive()
  }
}

# overrides for Pester Describe/Context/It

function Describe(
  [Parameter(Mandatory = $true, Position = 0)]
  [string] $Name,

  [Alias('Tags')]
  [string[]] $Tag = @(),

  [Parameter(Position = 1)]
  [ValidateNotNull()]
  [ScriptBlock] $Fixture = $(Throw "No test script block is provided. (Have you put the open curly brace on the next line?)")
) {
  $Mock.PushDescription($Name)
  try {
    return pester\Describe -Name $Name -Tag $Tag -Fixture $fixture
  }
  finally {
    $Mock.PopDescription()
  }
}

function Context(
  [Parameter(Mandatory = $true, Position = 0)]
  [string] $Name,

  [Alias('Tags')]
  [string[]] $Tag = @(),

  [Parameter(Position = 1)]
  [ValidateNotNull()]
  [ScriptBlock] $Fixture = $(Throw "No test script block is provided. (Have you put the open curly brace on the next line?)")
) {
  $Mock.PushContext($Name)
  try {
    return pester\Context -Name $Name -Tag $Tag -Fixture $fixture
  }
  finally {
    $Mock.PopContext()
  }
}

function It {
  [CmdletBinding(DefaultParameterSetName = 'Normal')]
  param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string]$Name,

    [Parameter(Position = 1)]
    [ScriptBlock] $Test = { },

    [System.Collections.IDictionary[]] $TestCases,

    [Parameter(ParameterSetName = 'Pending')]
    [Switch] $Pending,

    [Parameter(ParameterSetName = 'Skip')]
    [Alias('Ignore')]
    [Switch] $Skip
  )
  $Mock.PushScenario($Name)

  try {
    if ($skip) {
      return pester\It -Name $Name -Test $Test -TestCases $TestCases -Skip
    }
    if ($pending) {
      return pester\It -Name $Name -Test $Test -TestCases $TestCases -Pending
    }
    return pester\It -Name $Name -Test $Test -TestCases $TestCases
  }
  finally {
    $null = $Mock.PopScenario()
  }
}

# set the HttpPipelineAppend for all the cmdlets
$PSDefaultParameterValues["*:HttpPipelineAppend"] = $Mock
