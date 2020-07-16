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

Device type used when booting from a local disk device.

.PARAMETER ObjectType
The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types.
.PARAMETER Enabled
Specifies if the boot device is enabled or disabled.
.PARAMETER Name
A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters.
.PARAMETER Bootloader
No description available.
.PARAMETER Slot
The slot id of the local disk device. Supported values are (1-255, ""M"", ""HBA"", ""SAS"", ""RAID"", ""MRAID"", ""MSTOR-RAID"").
.OUTPUTS

BootLocalDisk<PSCustomObject>
#>

function Initialize-IntersightBootLocalDisk {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("((^[a-zA-Z0-9]$){1,30}|(^(([a-zA-Z0-9])([a-zA-Z0-9_\\-]{0,28})([a-zA-Z0-9]))$))")]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Bootloader},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]|M|HBA|SAS|MRAID|RAID|MSTOR-RAID)$")]
        [String]
        ${Slot}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightBootLocalDisk' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "ObjectType" = ${ObjectType}
            "Enabled" = ${Enabled}
            "Name" = ${Name}
            "Bootloader" = ${Bootloader}
            "Slot" = ${Slot}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to BootLocalDisk<PSCustomObject>

.DESCRIPTION

Convert from JSON to BootLocalDisk<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

BootLocalDisk<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToBootLocalDisk {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightBootLocalDisk' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightBootLocalDisk
        $AllProperties = ("ClassId", "ObjectType", "Enabled", "Name", "Bootloader", "Slot")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Bootloader"))) { #optional property not found
            $Bootloader = $null
        } else {
            $Bootloader = $JsonParameters.PSobject.Properties["Bootloader"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Slot"))) { #optional property not found
            $Slot = $null
        } else {
            $Slot = $JsonParameters.PSobject.Properties["Slot"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Enabled" = ${Enabled}
            "Name" = ${Name}
            "Bootloader" = ${Bootloader}
            "Slot" = ${Slot}
        }

        return $PSO
    }

}

