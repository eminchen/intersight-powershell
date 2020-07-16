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

Definition of the list of properties defined in 'equipment.IoCard', excluding properties defined in parent classes.

.PARAMETER EquipmentChassis
No description available.
.PARAMETER InventoryDeviceInfo
No description available.
.PARAMETER PhysicalDeviceRegistration
No description available.
.PARAMETER RegisteredDevice
No description available.
.OUTPUTS

EquipmentIoCardAllOf<PSCustomObject>
#>

function Initialize-IntersightEquipmentIoCardAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${EquipmentChassis},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InventoryDeviceInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PhysicalDeviceRegistration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightEquipmentIoCardAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EquipmentChassis" = ${EquipmentChassis}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "PhysicalDeviceRegistration" = ${PhysicalDeviceRegistration}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to EquipmentIoCardAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to EquipmentIoCardAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

EquipmentIoCardAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToEquipmentIoCardAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightEquipmentIoCardAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightEquipmentIoCardAllOf
        $AllProperties = ("ConnectionPath", "DcSupported", "Side", "EquipmentChassis", "InventoryDeviceInfo", "PhysicalDeviceRegistration", "RegisteredDevice")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectionPath"))) { #optional property not found
            $ConnectionPath = $null
        } else {
            $ConnectionPath = $JsonParameters.PSobject.Properties["ConnectionPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DcSupported"))) { #optional property not found
            $DcSupported = $null
        } else {
            $DcSupported = $JsonParameters.PSobject.Properties["DcSupported"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Side"))) { #optional property not found
            $Side = $null
        } else {
            $Side = $JsonParameters.PSobject.Properties["Side"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EquipmentChassis"))) { #optional property not found
            $EquipmentChassis = $null
        } else {
            $EquipmentChassis = $JsonParameters.PSobject.Properties["EquipmentChassis"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InventoryDeviceInfo"))) { #optional property not found
            $InventoryDeviceInfo = $null
        } else {
            $InventoryDeviceInfo = $JsonParameters.PSobject.Properties["InventoryDeviceInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhysicalDeviceRegistration"))) { #optional property not found
            $PhysicalDeviceRegistration = $null
        } else {
            $PhysicalDeviceRegistration = $JsonParameters.PSobject.Properties["PhysicalDeviceRegistration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        $PSO = [PSCustomObject]@{
            "ConnectionPath" = ${ConnectionPath}
            "DcSupported" = ${DcSupported}
            "Side" = ${Side}
            "EquipmentChassis" = ${EquipmentChassis}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "PhysicalDeviceRegistration" = ${PhysicalDeviceRegistration}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }

}

