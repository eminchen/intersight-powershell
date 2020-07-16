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

A base abstract message for connector messages that require authentication to be passed from the Intersight services.

.PARAMETER ObjectType
The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types.
.PARAMETER EncryptedAesKey
The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property. The secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary.
.PARAMETER EncryptionKey
The public key that was used to encrypt the values present in SecureProperties dictionary. If the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back.
.PARAMETER SecureProperties
A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix Device connector expects the message body to be a golang template and the template can use the secure property names as placeholders.
.PARAMETER RemoteUserLocale
The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale.
.PARAMETER RemoteUserName
The user name passed to the platform for use in platform audit logs.
.PARAMETER RemoteUserRoles
The list of roles to pass to the platform to validate the action against.
.PARAMETER RemoteUserSessionId
The session Id passed to the platform for use in platforms auditing.
.OUTPUTS

ConnectorAuthMessage<PSCustomObject>
#>

function Initialize-IntersightConnectorAuthMessage {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${EncryptedAesKey},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${EncryptionKey},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecureProperties},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RemoteUserLocale},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RemoteUserName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RemoteUserRoles},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RemoteUserSessionId}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightConnectorAuthMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "ObjectType" = ${ObjectType}
            "EncryptedAesKey" = ${EncryptedAesKey}
            "EncryptionKey" = ${EncryptionKey}
            "SecureProperties" = ${SecureProperties}
            "RemoteUserLocale" = ${RemoteUserLocale}
            "RemoteUserName" = ${RemoteUserName}
            "RemoteUserRoles" = ${RemoteUserRoles}
            "RemoteUserSessionId" = ${RemoteUserSessionId}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to ConnectorAuthMessage<PSCustomObject>

.DESCRIPTION

Convert from JSON to ConnectorAuthMessage<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

ConnectorAuthMessage<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToConnectorAuthMessage {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightConnectorAuthMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightConnectorAuthMessage
        $AllProperties = ("ClassId", "ObjectType", "EncryptedAesKey", "EncryptionKey", "SecureProperties", "RemoteUserLocale", "RemoteUserName", "RemoteUserRoles", "RemoteUserSessionId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EncryptedAesKey"))) { #optional property not found
            $EncryptedAesKey = $null
        } else {
            $EncryptedAesKey = $JsonParameters.PSobject.Properties["EncryptedAesKey"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EncryptionKey"))) { #optional property not found
            $EncryptionKey = $null
        } else {
            $EncryptionKey = $JsonParameters.PSobject.Properties["EncryptionKey"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecureProperties"))) { #optional property not found
            $SecureProperties = $null
        } else {
            $SecureProperties = $JsonParameters.PSobject.Properties["SecureProperties"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RemoteUserLocale"))) { #optional property not found
            $RemoteUserLocale = $null
        } else {
            $RemoteUserLocale = $JsonParameters.PSobject.Properties["RemoteUserLocale"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RemoteUserName"))) { #optional property not found
            $RemoteUserName = $null
        } else {
            $RemoteUserName = $JsonParameters.PSobject.Properties["RemoteUserName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RemoteUserRoles"))) { #optional property not found
            $RemoteUserRoles = $null
        } else {
            $RemoteUserRoles = $JsonParameters.PSobject.Properties["RemoteUserRoles"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RemoteUserSessionId"))) { #optional property not found
            $RemoteUserSessionId = $null
        } else {
            $RemoteUserSessionId = $JsonParameters.PSobject.Properties["RemoteUserSessionId"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "EncryptedAesKey" = ${EncryptedAesKey}
            "EncryptionKey" = ${EncryptionKey}
            "SecureProperties" = ${SecureProperties}
            "RemoteUserLocale" = ${RemoteUserLocale}
            "RemoteUserName" = ${RemoteUserName}
            "RemoteUserRoles" = ${RemoteUserRoles}
            "RemoteUserSessionId" = ${RemoteUserSessionId}
        }

        return $PSO
    }

}

