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

Definition of the list of properties defined in 'equipment.FexOperation', excluding properties defined in parent classes.

.PARAMETER AdminLocatorLedAction
Action performed on the locator LED for a FEX.
.PARAMETER AdminLocatorLedActionState
Defines status of action performed on AdminLocatorLedState.
.PARAMETER DeviceRegistration
No description available.
.PARAMETER Fex
No description available.
.OUTPUTS

EquipmentFexOperationAllOf<PSCustomObject>
#>

function Initialize-IntersightEquipmentFexOperationAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("None", "TurnOn", "TurnOff")]
        [String]
        ${AdminLocatorLedAction} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("None", "Applied", "Applying", "Failed")]
        [String]
        ${AdminLocatorLedActionState} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeviceRegistration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Fex}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightEquipmentFexOperationAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AdminLocatorLedAction" = ${AdminLocatorLedAction}
            "AdminLocatorLedActionState" = ${AdminLocatorLedActionState}
            "DeviceRegistration" = ${DeviceRegistration}
            "Fex" = ${Fex}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to EquipmentFexOperationAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to EquipmentFexOperationAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

EquipmentFexOperationAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToEquipmentFexOperationAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightEquipmentFexOperationAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightEquipmentFexOperationAllOf
        $AllProperties = ("AdminLocatorLedAction", "AdminLocatorLedActionState", "DeviceRegistration", "Fex")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminLocatorLedAction"))) { #optional property not found
            $AdminLocatorLedAction = $null
        } else {
            $AdminLocatorLedAction = $JsonParameters.PSobject.Properties["AdminLocatorLedAction"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminLocatorLedActionState"))) { #optional property not found
            $AdminLocatorLedActionState = $null
        } else {
            $AdminLocatorLedActionState = $JsonParameters.PSobject.Properties["AdminLocatorLedActionState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeviceRegistration"))) { #optional property not found
            $DeviceRegistration = $null
        } else {
            $DeviceRegistration = $JsonParameters.PSobject.Properties["DeviceRegistration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Fex"))) { #optional property not found
            $Fex = $null
        } else {
            $Fex = $JsonParameters.PSobject.Properties["Fex"].value
        }

        $PSO = [PSCustomObject]@{
            "AdminLocatorLedAction" = ${AdminLocatorLedAction}
            "AdminLocatorLedActionState" = ${AdminLocatorLedActionState}
            "DeviceRegistration" = ${DeviceRegistration}
            "Fex" = ${Fex}
        }

        return $PSO
    }

}

