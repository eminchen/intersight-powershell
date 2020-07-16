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

VLAN configuration for the virtual interface.

.PARAMETER ObjectType
The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types.
.PARAMETER AllowedVlans
Allowed VLAN IDs of the virtual interface.
.PARAMETER DefaultVlan
Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. Setting the ID to 0 will not associate any native VLAN to the traffic on the virtual interface.
.PARAMETER Mode
Option to determine if the port can carry single VLAN (Access) or multiple VLANs (Trunk) traffic.
.OUTPUTS

VnicVlanSettings<PSCustomObject>
#>

function Initialize-IntersightVnicVlanSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        [String]
        ${AllowedVlans},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${DefaultVlan},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("ACCESS", "TRUNK")]
        [String]
        ${Mode} = "ACCESS"
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightVnicVlanSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if (!$DefaultVlan -and $DefaultVlan -gt 4094) {
          throw "invalid value for 'DefaultVlan', must be smaller than or equal to 4094."
        }

        if (!$DefaultVlan -and $DefaultVlan -lt 0) {
          throw "invalid value for 'DefaultVlan', must be greater than or equal to 0."
        }

        
        $PSO = [PSCustomObject]@{
            "ObjectType" = ${ObjectType}
            "AllowedVlans" = ${AllowedVlans}
            "DefaultVlan" = ${DefaultVlan}
            "Mode" = ${Mode}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to VnicVlanSettings<PSCustomObject>

.DESCRIPTION

Convert from JSON to VnicVlanSettings<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

VnicVlanSettings<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToVnicVlanSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightVnicVlanSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightVnicVlanSettings
        $AllProperties = ("ClassId", "ObjectType", "AllowedVlans", "DefaultVlan", "Mode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property `ClassId` missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property `ClassId` missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property `ObjectType` missing."
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowedVlans"))) { #optional property not found
            $AllowedVlans = $null
        } else {
            $AllowedVlans = $JsonParameters.PSobject.Properties["AllowedVlans"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultVlan"))) { #optional property not found
            $DefaultVlan = $null
        } else {
            $DefaultVlan = $JsonParameters.PSobject.Properties["DefaultVlan"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Mode"))) { #optional property not found
            $Mode = $null
        } else {
            $Mode = $JsonParameters.PSobject.Properties["Mode"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "AllowedVlans" = ${AllowedVlans}
            "DefaultVlan" = ${DefaultVlan}
            "Mode" = ${Mode}
        }

        return $PSO
    }

}

