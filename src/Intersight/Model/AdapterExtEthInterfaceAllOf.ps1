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

Definition of the list of properties defined in 'adapter.ExtEthInterface', excluding properties defined in parent classes.

.PARAMETER AdapterUnit
No description available.
.PARAMETER InventoryDeviceInfo
No description available.
.PARAMETER RegisteredDevice
No description available.
.OUTPUTS

AdapterExtEthInterfaceAllOf<PSCustomObject>
#>

function Initialize-IntersightAdapterExtEthInterfaceAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AdapterUnit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InventoryDeviceInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightAdapterExtEthInterfaceAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AdapterUnit" = ${AdapterUnit}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to AdapterExtEthInterfaceAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to AdapterExtEthInterfaceAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

AdapterExtEthInterfaceAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToAdapterExtEthInterfaceAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightAdapterExtEthInterfaceAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightAdapterExtEthInterfaceAllOf
        $AllProperties = ("AdminState", "EpDn", "ExtEthInterfaceId", "InterfaceType", "MacAddress", "PeerAggrPortId", "PeerDn", "PeerPortId", "PeerSlotId", "SwitchId", "AdapterUnit", "InventoryDeviceInfo", "RegisteredDevice")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminState"))) { #optional property not found
            $AdminState = $null
        } else {
            $AdminState = $JsonParameters.PSobject.Properties["AdminState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EpDn"))) { #optional property not found
            $EpDn = $null
        } else {
            $EpDn = $JsonParameters.PSobject.Properties["EpDn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtEthInterfaceId"))) { #optional property not found
            $ExtEthInterfaceId = $null
        } else {
            $ExtEthInterfaceId = $JsonParameters.PSobject.Properties["ExtEthInterfaceId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InterfaceType"))) { #optional property not found
            $InterfaceType = $null
        } else {
            $InterfaceType = $JsonParameters.PSobject.Properties["InterfaceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MacAddress"))) { #optional property not found
            $MacAddress = $null
        } else {
            $MacAddress = $JsonParameters.PSobject.Properties["MacAddress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeerAggrPortId"))) { #optional property not found
            $PeerAggrPortId = $null
        } else {
            $PeerAggrPortId = $JsonParameters.PSobject.Properties["PeerAggrPortId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeerDn"))) { #optional property not found
            $PeerDn = $null
        } else {
            $PeerDn = $JsonParameters.PSobject.Properties["PeerDn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeerPortId"))) { #optional property not found
            $PeerPortId = $null
        } else {
            $PeerPortId = $JsonParameters.PSobject.Properties["PeerPortId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeerSlotId"))) { #optional property not found
            $PeerSlotId = $null
        } else {
            $PeerSlotId = $JsonParameters.PSobject.Properties["PeerSlotId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SwitchId"))) { #optional property not found
            $SwitchId = $null
        } else {
            $SwitchId = $JsonParameters.PSobject.Properties["SwitchId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdapterUnit"))) { #optional property not found
            $AdapterUnit = $null
        } else {
            $AdapterUnit = $JsonParameters.PSobject.Properties["AdapterUnit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InventoryDeviceInfo"))) { #optional property not found
            $InventoryDeviceInfo = $null
        } else {
            $InventoryDeviceInfo = $JsonParameters.PSobject.Properties["InventoryDeviceInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        $PSO = [PSCustomObject]@{
            "AdminState" = ${AdminState}
            "EpDn" = ${EpDn}
            "ExtEthInterfaceId" = ${ExtEthInterfaceId}
            "InterfaceType" = ${InterfaceType}
            "MacAddress" = ${MacAddress}
            "PeerAggrPortId" = ${PeerAggrPortId}
            "PeerDn" = ${PeerDn}
            "PeerPortId" = ${PeerPortId}
            "PeerSlotId" = ${PeerSlotId}
            "SwitchId" = ${SwitchId}
            "AdapterUnit" = ${AdapterUnit}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }

}

