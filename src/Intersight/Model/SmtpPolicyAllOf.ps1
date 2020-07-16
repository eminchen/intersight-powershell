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

Definition of the list of properties defined in 'smtp.Policy', excluding properties defined in parent classes.

.PARAMETER Enabled
If enabled, controls the state of the SMTP client service on the managed device.
.PARAMETER MinSeverity
Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level.
.PARAMETER SenderEmail
The email address entered here will be displayed as the from address (mail received from address) of all the SMTP mail alerts that are received. If not configured, the hostname of the server is used in the from address field.
.PARAMETER SmtpPort
Port number used by the SMTP server for outgoing SMTP communication.
.PARAMETER SmtpRecipients
No description available.
.PARAMETER SmtpServer
IP address or hostname of the SMTP server. The SMTP server is used by the managed device to send email notifications.
.PARAMETER Organization
No description available.
.PARAMETER Profiles
An array of relationships to policyAbstractConfigProfile resources.
.OUTPUTS

SmtpPolicyAllOf<PSCustomObject>
#>

function Initialize-IntersightSmtpPolicyAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("critical", "condition", "warning", "minor", "major")]
        [String]
        ${MinSeverity} = "critical",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        [String]
        ${SenderEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${SmtpPort},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${SmtpRecipients},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SmtpServer},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Organization},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Profiles}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightSmtpPolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$SmtpPort -and $SmtpPort -gt 65535) {
          throw "invalid value for 'SmtpPort', must be smaller than or equal to 65535."
        }

        if (!$SmtpPort -and $SmtpPort -lt 1) {
          throw "invalid value for 'SmtpPort', must be greater than or equal to 1."
        }

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "MinSeverity" = ${MinSeverity}
            "SenderEmail" = ${SenderEmail}
            "SmtpPort" = ${SmtpPort}
            "SmtpRecipients" = ${SmtpRecipients}
            "SmtpServer" = ${SmtpServer}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to SmtpPolicyAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to SmtpPolicyAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

SmtpPolicyAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToSmtpPolicyAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightSmtpPolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightSmtpPolicyAllOf
        $AllProperties = ("Enabled", "MinSeverity", "SenderEmail", "SmtpPort", "SmtpRecipients", "SmtpServer", "Organization", "Profiles")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MinSeverity"))) { #optional property not found
            $MinSeverity = $null
        } else {
            $MinSeverity = $JsonParameters.PSobject.Properties["MinSeverity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SenderEmail"))) { #optional property not found
            $SenderEmail = $null
        } else {
            $SenderEmail = $JsonParameters.PSobject.Properties["SenderEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SmtpPort"))) { #optional property not found
            $SmtpPort = $null
        } else {
            $SmtpPort = $JsonParameters.PSobject.Properties["SmtpPort"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SmtpRecipients"))) { #optional property not found
            $SmtpRecipients = $null
        } else {
            $SmtpRecipients = $JsonParameters.PSobject.Properties["SmtpRecipients"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SmtpServer"))) { #optional property not found
            $SmtpServer = $null
        } else {
            $SmtpServer = $JsonParameters.PSobject.Properties["SmtpServer"].value
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
            "Enabled" = ${Enabled}
            "MinSeverity" = ${MinSeverity}
            "SenderEmail" = ${SenderEmail}
            "SmtpPort" = ${SmtpPort}
            "SmtpRecipients" = ${SmtpRecipients}
            "SmtpServer" = ${SmtpServer}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }

}

