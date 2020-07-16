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

Definition of the list of properties defined in 'memory.PersistentMemoryLocalSecurity', excluding properties defined in parent classes.

.PARAMETER Enabled
Persistent Memory Security state.
.PARAMETER SecurePassphrase
Secure passphrase to be applied on the Persistent Memory Modules on the server. The allowed characters are a-z, A to Z, 0-9, and special characters =, \\u0021, &, \\#, $, %, +, ^, @, _, *, -.
.OUTPUTS

MemoryPersistentMemoryLocalSecurityAllOf<PSCustomObject>
#>

function Initialize-IntersightMemoryPersistentMemoryLocalSecurityAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^[a-zA-Z0-9=!&#$%+^@_*-]+$")]
        [String]
        ${SecurePassphrase}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightMemoryPersistentMemoryLocalSecurityAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$SecurePassphrase -and $SecurePassphrase.length -gt 32) {
            throw "invalid value for 'SecurePassphrase', the character length must be smaller than or equal to 32."
        }

        if (!$SecurePassphrase -and $SecurePassphrase.length -lt 8) {
            throw "invalid value for 'SecurePassphrase', the character length must be great than or equal to 8."
        }

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "SecurePassphrase" = ${SecurePassphrase}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to MemoryPersistentMemoryLocalSecurityAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to MemoryPersistentMemoryLocalSecurityAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

MemoryPersistentMemoryLocalSecurityAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToMemoryPersistentMemoryLocalSecurityAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightMemoryPersistentMemoryLocalSecurityAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightMemoryPersistentMemoryLocalSecurityAllOf
        $AllProperties = ("Enabled", "IsSecurePassphraseSet", "SecurePassphrase")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSecurePassphraseSet"))) { #optional property not found
            $IsSecurePassphraseSet = $null
        } else {
            $IsSecurePassphraseSet = $JsonParameters.PSobject.Properties["IsSecurePassphraseSet"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecurePassphrase"))) { #optional property not found
            $SecurePassphrase = $null
        } else {
            $SecurePassphrase = $JsonParameters.PSobject.Properties["SecurePassphrase"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "IsSecurePassphraseSet" = ${IsSecurePassphraseSet}
            "SecurePassphrase" = ${SecurePassphrase}
        }

        return $PSO
    }

}

