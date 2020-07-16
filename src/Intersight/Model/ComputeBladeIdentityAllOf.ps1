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

Definition of the list of properties defined in 'compute.BladeIdentity', excluding properties defined in parent classes.

.PARAMETER ChassisId
Chassis Identifier of a blade server.
.PARAMETER DeviceMoId
FI Device registration Mo ID.
.PARAMETER PendingDiscovery
Indicates pending discovery flag.
.PARAMETER SlotId
Chassis slot number of a blade server.
.OUTPUTS

ComputeBladeIdentityAllOf<PSCustomObject>
#>

function Initialize-IntersightComputeBladeIdentityAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${ChassisId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DeviceMoId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PendingDiscovery},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${SlotId}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightComputeBladeIdentityAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ChassisId" = ${ChassisId}
            "DeviceMoId" = ${DeviceMoId}
            "PendingDiscovery" = ${PendingDiscovery}
            "SlotId" = ${SlotId}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to ComputeBladeIdentityAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to ComputeBladeIdentityAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

ComputeBladeIdentityAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToComputeBladeIdentityAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightComputeBladeIdentityAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightComputeBladeIdentityAllOf
        $AllProperties = ("ChassisId", "DeviceMoId", "PendingDiscovery", "SlotId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChassisId"))) { #optional property not found
            $ChassisId = $null
        } else {
            $ChassisId = $JsonParameters.PSobject.Properties["ChassisId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeviceMoId"))) { #optional property not found
            $DeviceMoId = $null
        } else {
            $DeviceMoId = $JsonParameters.PSobject.Properties["DeviceMoId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PendingDiscovery"))) { #optional property not found
            $PendingDiscovery = $null
        } else {
            $PendingDiscovery = $JsonParameters.PSobject.Properties["PendingDiscovery"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SlotId"))) { #optional property not found
            $SlotId = $null
        } else {
            $SlotId = $JsonParameters.PSobject.Properties["SlotId"].value
        }

        $PSO = [PSCustomObject]@{
            "ChassisId" = ${ChassisId}
            "DeviceMoId" = ${DeviceMoId}
            "PendingDiscovery" = ${PendingDiscovery}
            "SlotId" = ${SlotId}
        }

        return $PSO
    }

}

