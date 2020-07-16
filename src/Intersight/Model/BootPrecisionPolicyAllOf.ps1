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

Definition of the list of properties defined in 'boot.PrecisionPolicy', excluding properties defined in parent classes.

.PARAMETER BootDevices
No description available.
.PARAMETER ConfiguredBootMode
Sets the BIOS boot mode. UEFI uses the GUID Partition Table (GPT) whereas Legacy mode uses the Master Boot Record (MBR) partitioning scheme.
.PARAMETER EnforceUefiSecureBoot
If UEFI secure boot is enabled, the boot mode is set to UEFI by default. Secure boot enforces that device boots using only software that is trusted by the Original Equipment Manufacturer (OEM).
.PARAMETER Organization
No description available.
.PARAMETER Profiles
An array of relationships to policyAbstractConfigProfile resources.
.OUTPUTS

BootPrecisionPolicyAllOf<PSCustomObject>
#>

function Initialize-IntersightBootPrecisionPolicyAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${BootDevices},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Legacy", "Uefi")]
        [String]
        ${ConfiguredBootMode} = "Legacy",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnforceUefiSecureBoot},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Organization},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Profiles}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightBootPrecisionPolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "BootDevices" = ${BootDevices}
            "ConfiguredBootMode" = ${ConfiguredBootMode}
            "EnforceUefiSecureBoot" = ${EnforceUefiSecureBoot}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to BootPrecisionPolicyAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to BootPrecisionPolicyAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

BootPrecisionPolicyAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToBootPrecisionPolicyAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightBootPrecisionPolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightBootPrecisionPolicyAllOf
        $AllProperties = ("BootDevices", "ConfiguredBootMode", "EnforceUefiSecureBoot", "Organization", "Profiles")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BootDevices"))) { #optional property not found
            $BootDevices = $null
        } else {
            $BootDevices = $JsonParameters.PSobject.Properties["BootDevices"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConfiguredBootMode"))) { #optional property not found
            $ConfiguredBootMode = $null
        } else {
            $ConfiguredBootMode = $JsonParameters.PSobject.Properties["ConfiguredBootMode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnforceUefiSecureBoot"))) { #optional property not found
            $EnforceUefiSecureBoot = $null
        } else {
            $EnforceUefiSecureBoot = $JsonParameters.PSobject.Properties["EnforceUefiSecureBoot"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Organization"))) { #optional property not found
            $Organization = $null
        } else {
            $Organization = $JsonParameters.PSobject.Properties["Organization"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Profiles"))) { #optional property not found
            $Profiles = $null
        } else {
            $Profiles = $JsonParameters.PSobject.Properties["Profiles"].value
        }

        $PSO = [PSCustomObject]@{
            "BootDevices" = ${BootDevices}
            "ConfiguredBootMode" = ${ConfiguredBootMode}
            "EnforceUefiSecureBoot" = ${EnforceUefiSecureBoot}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }

}

