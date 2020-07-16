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

Definition of the list of properties defined in 'hyperflex.ConfigResult', excluding properties defined in parent classes.

.PARAMETER ConfigProgress
The progress percentage of the running configuration or workflow.
.PARAMETER Duration
The duration of the running configuration or workflow.
.PARAMETER StartTime
The start time of the configuration or workflow.
.PARAMETER ClusterProfile
No description available.
.PARAMETER ResultEntries
An array of relationships to hyperflexConfigResultEntry resources.
.OUTPUTS

HyperflexConfigResultAllOf<PSCustomObject>
#>

function Initialize-IntersightHyperflexConfigResultAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ConfigProgress},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Duration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ClusterProfile},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ResultEntries}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightHyperflexConfigResultAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ConfigProgress" = ${ConfigProgress}
            "Duration" = ${Duration}
            "StartTime" = ${StartTime}
            "ClusterProfile" = ${ClusterProfile}
            "ResultEntries" = ${ResultEntries}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to HyperflexConfigResultAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to HyperflexConfigResultAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

HyperflexConfigResultAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToHyperflexConfigResultAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightHyperflexConfigResultAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightHyperflexConfigResultAllOf
        $AllProperties = ("ConfigProgress", "Duration", "StartTime", "ClusterProfile", "ResultEntries")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConfigProgress"))) { #optional property not found
            $ConfigProgress = $null
        } else {
            $ConfigProgress = $JsonParameters.PSobject.Properties["ConfigProgress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Duration"))) { #optional property not found
            $Duration = $null
        } else {
            $Duration = $JsonParameters.PSobject.Properties["Duration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartTime"))) { #optional property not found
            $StartTime = $null
        } else {
            $StartTime = $JsonParameters.PSobject.Properties["StartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClusterProfile"))) { #optional property not found
            $ClusterProfile = $null
        } else {
            $ClusterProfile = $JsonParameters.PSobject.Properties["ClusterProfile"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ResultEntries"))) { #optional property not found
            $ResultEntries = $null
        } else {
            $ResultEntries = $JsonParameters.PSobject.Properties["ResultEntries"].value
        }

        $PSO = [PSCustomObject]@{
            "ConfigProgress" = ${ConfigProgress}
            "Duration" = ${Duration}
            "StartTime" = ${StartTime}
            "ClusterProfile" = ${ClusterProfile}
            "ResultEntries" = ${ResultEntries}
        }

        return $PSO
    }

}

