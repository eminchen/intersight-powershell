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

Definition of the list of properties defined in 'top.System', excluding properties defined in parent classes.

.PARAMETER TimeZone
The operational timezone of the system, empty indicates no timezone has been set specifically.
.PARAMETER ComputeBlades
An array of relationships to computeBlade resources.
.PARAMETER InventoryDeviceInfo
No description available.
.PARAMETER ManagementController
No description available.
.PARAMETER NetworkElements
An array of relationships to networkElement resources.
.PARAMETER RegisteredDevice
No description available.
.OUTPUTS

TopSystemAllOf<PSCustomObject>
#>

function Initialize-IntersightTopSystemAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TimeZone},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ComputeBlades},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InventoryDeviceInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ManagementController},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${NetworkElements},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTopSystemAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TimeZone" = ${TimeZone}
            "ComputeBlades" = ${ComputeBlades}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "ManagementController" = ${ManagementController}
            "NetworkElements" = ${NetworkElements}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TopSystemAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to TopSystemAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TopSystemAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTopSystemAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTopSystemAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTopSystemAllOf
        $AllProperties = ("Ipv4Address", "Ipv6Address", "Mode", "Name", "TimeZone", "ComputeBlades", "ComputeRackUnits", "InventoryDeviceInfo", "ManagementController", "NetworkElements", "RegisteredDevice")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Ipv4Address"))) { #optional property not found
            $Ipv4Address = $null
        } else {
            $Ipv4Address = $JsonParameters.PSobject.Properties["Ipv4Address"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Ipv6Address"))) { #optional property not found
            $Ipv6Address = $null
        } else {
            $Ipv6Address = $JsonParameters.PSobject.Properties["Ipv6Address"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Mode"))) { #optional property not found
            $Mode = $null
        } else {
            $Mode = $JsonParameters.PSobject.Properties["Mode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZone"))) { #optional property not found
            $TimeZone = $null
        } else {
            $TimeZone = $JsonParameters.PSobject.Properties["TimeZone"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComputeBlades"))) { #optional property not found
            $ComputeBlades = $null
        } else {
            $ComputeBlades = $JsonParameters.PSobject.Properties["ComputeBlades"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComputeRackUnits"))) { #optional property not found
            $ComputeRackUnits = $null
        } else {
            $ComputeRackUnits = $JsonParameters.PSobject.Properties["ComputeRackUnits"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InventoryDeviceInfo"))) { #optional property not found
            $InventoryDeviceInfo = $null
        } else {
            $InventoryDeviceInfo = $JsonParameters.PSobject.Properties["InventoryDeviceInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManagementController"))) { #optional property not found
            $ManagementController = $null
        } else {
            $ManagementController = $JsonParameters.PSobject.Properties["ManagementController"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkElements"))) { #optional property not found
            $NetworkElements = $null
        } else {
            $NetworkElements = $JsonParameters.PSobject.Properties["NetworkElements"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        $PSO = [PSCustomObject]@{
            "Ipv4Address" = ${Ipv4Address}
            "Ipv6Address" = ${Ipv6Address}
            "Mode" = ${Mode}
            "Name" = ${Name}
            "TimeZone" = ${TimeZone}
            "ComputeBlades" = ${ComputeBlades}
            "ComputeRackUnits" = ${ComputeRackUnits}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "ManagementController" = ${ManagementController}
            "NetworkElements" = ${NetworkElements}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }

}

