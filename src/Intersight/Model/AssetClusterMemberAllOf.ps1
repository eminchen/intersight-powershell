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

Definition of the list of properties defined in 'asset.ClusterMember', excluding properties defined in parent classes.

.PARAMETER LockedLeader
Devices lock their leadership on failure to heartbeat with peers. Value acts as a third party tie breaker in election between nodes. Intersight enforces that only one cluster member exists with this value set to true.
.PARAMETER Sudi
No description available.
.PARAMETER Device
No description available.
.OUTPUTS

AssetClusterMemberAllOf<PSCustomObject>
#>

function Initialize-IntersightAssetClusterMemberAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LockedLeader},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Sudi},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Device}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightAssetClusterMemberAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "LockedLeader" = ${LockedLeader}
            "Sudi" = ${Sudi}
            "Device" = ${Device}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to AssetClusterMemberAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to AssetClusterMemberAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

AssetClusterMemberAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToAssetClusterMemberAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightAssetClusterMemberAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightAssetClusterMemberAllOf
        $AllProperties = ("Leadership", "LockedLeader", "MemberIdentity", "ParentClusterMemberIdentity", "Sudi", "Device")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Leadership"))) { #optional property not found
            $Leadership = $null
        } else {
            $Leadership = $JsonParameters.PSobject.Properties["Leadership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LockedLeader"))) { #optional property not found
            $LockedLeader = $null
        } else {
            $LockedLeader = $JsonParameters.PSobject.Properties["LockedLeader"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MemberIdentity"))) { #optional property not found
            $MemberIdentity = $null
        } else {
            $MemberIdentity = $JsonParameters.PSobject.Properties["MemberIdentity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentClusterMemberIdentity"))) { #optional property not found
            $ParentClusterMemberIdentity = $null
        } else {
            $ParentClusterMemberIdentity = $JsonParameters.PSobject.Properties["ParentClusterMemberIdentity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sudi"))) { #optional property not found
            $Sudi = $null
        } else {
            $Sudi = $JsonParameters.PSobject.Properties["Sudi"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Device"))) { #optional property not found
            $Device = $null
        } else {
            $Device = $JsonParameters.PSobject.Properties["Device"].value
        }

        $PSO = [PSCustomObject]@{
            "Leadership" = ${Leadership}
            "LockedLeader" = ${LockedLeader}
            "MemberIdentity" = ${MemberIdentity}
            "ParentClusterMemberIdentity" = ${ParentClusterMemberIdentity}
            "Sudi" = ${Sudi}
            "Device" = ${Device}
        }

        return $PSO
    }

}

