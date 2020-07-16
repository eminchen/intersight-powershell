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

Definition of the list of properties defined in 'techsupportmanagement.TechSupportBundle', excluding properties defined in parent classes.

.PARAMETER VarPid
Product identification of the device.
.PARAMETER PlatformParam
No description available.
.PARAMETER PlatformType
The platform type of the device.
.PARAMETER Serial
Serial number of the device.
.PARAMETER DeviceRegistration
No description available.
.PARAMETER TargetResource
No description available.
.PARAMETER TechSupportStatus
No description available.
.OUTPUTS

TechsupportmanagementTechSupportBundleAllOf<PSCustomObject>
#>

function Initialize-IntersightTechsupportmanagementTechSupportBundleAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${VarPid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PlatformParam},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("", "APIC", "DCNM", "UCSFI", "UCSFIISM", "IMC", "IMCM4", "IMCM5", "UCSIOM", "HX", "HyperFlexAP", "UCSD", "IntersightAppliance", "PureStorageFlashArray", "NetAppOntap", "EmcScaleIo", "EmcVmax", "EmcVplex", "EmcXtremIo", "VmwareVcenter", "MicrosoftHyperV", "AppDynamics", "Dynatrace", "MicrosoftSqlServer", "Kubernetes", "MicrosoftAzure", "ServiceEngine", "IMCBlade")]
        [String]
        ${PlatformType} = "",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Serial},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeviceRegistration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TargetResource},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TechSupportStatus}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTechsupportmanagementTechSupportBundleAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Pid" = ${VarPid}
            "PlatformParam" = ${PlatformParam}
            "PlatformType" = ${PlatformType}
            "Serial" = ${Serial}
            "DeviceRegistration" = ${DeviceRegistration}
            "TargetResource" = ${TargetResource}
            "TechSupportStatus" = ${TechSupportStatus}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TechsupportmanagementTechSupportBundleAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to TechsupportmanagementTechSupportBundleAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TechsupportmanagementTechSupportBundleAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTechsupportmanagementTechSupportBundleAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTechsupportmanagementTechSupportBundleAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTechsupportmanagementTechSupportBundleAllOf
        $AllProperties = ("DeviceIdentifier", "DeviceType", "Pid", "PlatformParam", "PlatformType", "Serial", "DeviceRegistration", "TargetResource", "TechSupportStatus")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeviceIdentifier"))) { #optional property not found
            $DeviceIdentifier = $null
        } else {
            $DeviceIdentifier = $JsonParameters.PSobject.Properties["DeviceIdentifier"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeviceType"))) { #optional property not found
            $DeviceType = $null
        } else {
            $DeviceType = $JsonParameters.PSobject.Properties["DeviceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Pid"))) { #optional property not found
            $VarPid = $null
        } else {
            $VarPid = $JsonParameters.PSobject.Properties["Pid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PlatformParam"))) { #optional property not found
            $PlatformParam = $null
        } else {
            $PlatformParam = $JsonParameters.PSobject.Properties["PlatformParam"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PlatformType"))) { #optional property not found
            $PlatformType = $null
        } else {
            $PlatformType = $JsonParameters.PSobject.Properties["PlatformType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Serial"))) { #optional property not found
            $Serial = $null
        } else {
            $Serial = $JsonParameters.PSobject.Properties["Serial"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeviceRegistration"))) { #optional property not found
            $DeviceRegistration = $null
        } else {
            $DeviceRegistration = $JsonParameters.PSobject.Properties["DeviceRegistration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetResource"))) { #optional property not found
            $TargetResource = $null
        } else {
            $TargetResource = $JsonParameters.PSobject.Properties["TargetResource"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TechSupportStatus"))) { #optional property not found
            $TechSupportStatus = $null
        } else {
            $TechSupportStatus = $JsonParameters.PSobject.Properties["TechSupportStatus"].value
        }

        $PSO = [PSCustomObject]@{
            "DeviceIdentifier" = ${DeviceIdentifier}
            "DeviceType" = ${DeviceType}
            "Pid" = ${VarPid}
            "PlatformParam" = ${PlatformParam}
            "PlatformType" = ${PlatformType}
            "Serial" = ${Serial}
            "DeviceRegistration" = ${DeviceRegistration}
            "TargetResource" = ${TargetResource}
            "TechSupportStatus" = ${TechSupportStatus}
        }

        return $PSO
    }

}

