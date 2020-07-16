#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Definition of the list of properties defined in 'tam.SecurityAdvisory', excluding properties defined in parent classes.

.PARAMETER Actions
No description available.
.PARAMETER AdvisoryId
Cisco generated identifier for the published security advisory.
.PARAMETER ApiDataSources
No description available.
.PARAMETER BaseScore
CVSS version 3 base score for the security Advisory.
.PARAMETER CveIds
No description available.
.PARAMETER DatePublished
Date when the security advisory was first published by Cisco.
.PARAMETER DateUpdated
Date when the security advisory was last updated by Cisco.
.PARAMETER EnvironmentalScore
CVSS version 3 environmental score for the security Advisory.
.PARAMETER ExternalUrl
A link to an external URL describing security Advisory in more details.
.PARAMETER Recommendation
Recommended action to resolve the security advisory.
.PARAMETER Status
Cisco assigned status of the published advisory based on whether the investigation is complete or on-going.
.PARAMETER TemporalScore
CVSS version 3 temporal score for the security Advisory.
.PARAMETER Version
Cisco assigned advisory version after latest revision.
.PARAMETER Workaround
Workarounds available for the advisory.
.PARAMETER Organization
No description available.
.OUTPUTS

TamSecurityAdvisoryAllOf<PSCustomObject>
#>

function Initialize-IntersightTamSecurityAdvisoryAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Actions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdvisoryId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ApiDataSources},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Decimal]]
        ${BaseScore},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${CveIds},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${DatePublished},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${DateUpdated},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Decimal]]
        ${EnvironmentalScore},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^(?:http(s)?://)?[\\w.-]+(?:\\.[\\w\\.-]+)+[\\w\\-\\._~:/?#[\\]@!\\$&'\\(\\)\\*\\+,;=.]+$")]
        [String]
        ${ExternalUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Recommendation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("interim", "final")]
        [String]
        ${Status} = "interim",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Decimal]]
        ${TemporalScore},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Version},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Workaround},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Organization}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTamSecurityAdvisoryAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$BaseScore -and $BaseScore -gt 10.0) {
          throw "invalid value for 'BaseScore', must be smaller than or equal to 10.0."
        }

        if (!$BaseScore -and $BaseScore -lt 0.0) {
          throw "invalid value for 'BaseScore', must be greater than or equal to 0.0."
        }

        if (!$EnvironmentalScore -and $EnvironmentalScore -gt 10.0) {
          throw "invalid value for 'EnvironmentalScore', must be smaller than or equal to 10.0."
        }

        if (!$EnvironmentalScore -and $EnvironmentalScore -lt 0.0) {
          throw "invalid value for 'EnvironmentalScore', must be greater than or equal to 0.0."
        }

        if (!$TemporalScore -and $TemporalScore -gt 10.0) {
          throw "invalid value for 'TemporalScore', must be smaller than or equal to 10.0."
        }

        if (!$TemporalScore -and $TemporalScore -lt 0.0) {
          throw "invalid value for 'TemporalScore', must be greater than or equal to 0.0."
        }

        
        $PSO = [PSCustomObject]@{
            "Actions" = ${Actions}
            "AdvisoryId" = ${AdvisoryId}
            "ApiDataSources" = ${ApiDataSources}
            "BaseScore" = ${BaseScore}
            "CveIds" = ${CveIds}
            "DatePublished" = ${DatePublished}
            "DateUpdated" = ${DateUpdated}
            "EnvironmentalScore" = ${EnvironmentalScore}
            "ExternalUrl" = ${ExternalUrl}
            "Recommendation" = ${Recommendation}
            "Status" = ${Status}
            "TemporalScore" = ${TemporalScore}
            "Version" = ${Version}
            "Workaround" = ${Workaround}
            "Organization" = ${Organization}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TamSecurityAdvisoryAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to TamSecurityAdvisoryAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TamSecurityAdvisoryAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTamSecurityAdvisoryAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTamSecurityAdvisoryAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTamSecurityAdvisoryAllOf
        $AllProperties = ("Actions", "AdvisoryId", "ApiDataSources", "BaseScore", "CveIds", "DatePublished", "DateUpdated", "EnvironmentalScore", "ExternalUrl", "Recommendation", "Status", "TemporalScore", "Version", "Workaround", "Organization")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Actions"))) { #optional property not found
            $Actions = $null
        } else {
            $Actions = $JsonParameters.PSobject.Properties["Actions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdvisoryId"))) { #optional property not found
            $AdvisoryId = $null
        } else {
            $AdvisoryId = $JsonParameters.PSobject.Properties["AdvisoryId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApiDataSources"))) { #optional property not found
            $ApiDataSources = $null
        } else {
            $ApiDataSources = $JsonParameters.PSobject.Properties["ApiDataSources"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BaseScore"))) { #optional property not found
            $BaseScore = $null
        } else {
            $BaseScore = $JsonParameters.PSobject.Properties["BaseScore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CveIds"))) { #optional property not found
            $CveIds = $null
        } else {
            $CveIds = $JsonParameters.PSobject.Properties["CveIds"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DatePublished"))) { #optional property not found
            $DatePublished = $null
        } else {
            $DatePublished = $JsonParameters.PSobject.Properties["DatePublished"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DateUpdated"))) { #optional property not found
            $DateUpdated = $null
        } else {
            $DateUpdated = $JsonParameters.PSobject.Properties["DateUpdated"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnvironmentalScore"))) { #optional property not found
            $EnvironmentalScore = $null
        } else {
            $EnvironmentalScore = $JsonParameters.PSobject.Properties["EnvironmentalScore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExternalUrl"))) { #optional property not found
            $ExternalUrl = $null
        } else {
            $ExternalUrl = $JsonParameters.PSobject.Properties["ExternalUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Recommendation"))) { #optional property not found
            $Recommendation = $null
        } else {
            $Recommendation = $JsonParameters.PSobject.Properties["Recommendation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemporalScore"))) { #optional property not found
            $TemporalScore = $null
        } else {
            $TemporalScore = $JsonParameters.PSobject.Properties["TemporalScore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Version"))) { #optional property not found
            $Version = $null
        } else {
            $Version = $JsonParameters.PSobject.Properties["Version"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Workaround"))) { #optional property not found
            $Workaround = $null
        } else {
            $Workaround = $JsonParameters.PSobject.Properties["Workaround"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Organization"))) { #optional property not found
            $Organization = $null
        } else {
            $Organization = $JsonParameters.PSobject.Properties["Organization"].value
        }

        $PSO = [PSCustomObject]@{
            "Actions" = ${Actions}
            "AdvisoryId" = ${AdvisoryId}
            "ApiDataSources" = ${ApiDataSources}
            "BaseScore" = ${BaseScore}
            "CveIds" = ${CveIds}
            "DatePublished" = ${DatePublished}
            "DateUpdated" = ${DateUpdated}
            "EnvironmentalScore" = ${EnvironmentalScore}
            "ExternalUrl" = ${ExternalUrl}
            "Recommendation" = ${Recommendation}
            "Status" = ${Status}
            "TemporalScore" = ${TemporalScore}
            "Version" = ${Version}
            "Workaround" = ${Workaround}
            "Organization" = ${Organization}
        }

        return $PSO
    }

}

