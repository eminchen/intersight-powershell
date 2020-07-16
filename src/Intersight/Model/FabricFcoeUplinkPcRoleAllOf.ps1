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

Definition of the list of properties defined in 'fabric.FcoeUplinkPcRole', excluding properties defined in parent classes.

.PARAMETER AdminSpeed
Admin configured speed for the port.
.PARAMETER UdldAdminState
Admin configured state for UDLD for this port.
.OUTPUTS

FabricFcoeUplinkPcRoleAllOf<PSCustomObject>
#>

function Initialize-IntersightFabricFcoeUplinkPcRoleAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Auto", "1Gbps", "10Gbps", "25Gbps", "40Gbps", "100Gbps")]
        [String]
        ${AdminSpeed} = "Auto",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Disabled", "Enabled")]
        [String]
        ${UdldAdminState} = "Disabled"
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFabricFcoeUplinkPcRoleAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AdminSpeed" = ${AdminSpeed}
            "UdldAdminState" = ${UdldAdminState}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FabricFcoeUplinkPcRoleAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to FabricFcoeUplinkPcRoleAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FabricFcoeUplinkPcRoleAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFabricFcoeUplinkPcRoleAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFabricFcoeUplinkPcRoleAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFabricFcoeUplinkPcRoleAllOf
        $AllProperties = ("AdminSpeed", "UdldAdminState")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminSpeed"))) { #optional property not found
            $AdminSpeed = $null
        } else {
            $AdminSpeed = $JsonParameters.PSobject.Properties["AdminSpeed"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UdldAdminState"))) { #optional property not found
            $UdldAdminState = $null
        } else {
            $UdldAdminState = $JsonParameters.PSobject.Properties["UdldAdminState"].value
        }

        $PSO = [PSCustomObject]@{
            "AdminSpeed" = ${AdminSpeed}
            "UdldAdminState" = ${UdldAdminState}
        }

        return $PSO
    }

}

