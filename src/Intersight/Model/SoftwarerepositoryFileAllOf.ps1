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

Definition of the list of properties defined in 'softwarerepository.File', excluding properties defined in parent classes.

.PARAMETER Description
User provided description about the file. Cisco provided description for image inventoried from a Cisco repository.
.PARAMETER ImportAction
The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.
.PARAMETER Md5sum
The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository.
.PARAMETER Name
The name of the file. It is populated as part of the image import operation.
.PARAMETER ReleaseDate
The date on which the file was released or distributed by its vendor.
.PARAMETER Sha512sum
The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository.
.PARAMETER Size
The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository.
.PARAMETER SoftwareAdvisoryUrl
The software advisory, if any, provided by the vendor for this file.
.PARAMETER Source
No description available.
.PARAMETER Version
Vendor provided version for the file.
.OUTPUTS

SoftwarerepositoryFileAllOf<PSCustomObject>
#>

function Initialize-IntersightSoftwarerepositoryFileAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("None", "GeneratePreSignedUploadUrl", "GeneratePreSignedDownloadUrl", "CompleteImportProcess", "MarkImportFailed", "PreCache", "Cancel", "Extract", "Evict")]
        [String]
        ${ImportAction} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Md5sum},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ReleaseDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Sha512sum},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${Size},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SoftwareAdvisoryUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Source},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Version}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightSoftwarerepositoryFileAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$Name -and $Name.length -gt 128) {
            throw "invalid value for 'Name', the character length must be smaller than or equal to 128."
        }

        
        $PSO = [PSCustomObject]@{
            "Description" = ${Description}
            "ImportAction" = ${ImportAction}
            "Md5sum" = ${Md5sum}
            "Name" = ${Name}
            "ReleaseDate" = ${ReleaseDate}
            "Sha512sum" = ${Sha512sum}
            "Size" = ${Size}
            "SoftwareAdvisoryUrl" = ${SoftwareAdvisoryUrl}
            "Source" = ${Source}
            "Version" = ${Version}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to SoftwarerepositoryFileAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to SoftwarerepositoryFileAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

SoftwarerepositoryFileAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToSoftwarerepositoryFileAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightSoftwarerepositoryFileAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightSoftwarerepositoryFileAllOf
        $AllProperties = ("Description", "DownloadCount", "ImportAction", "ImportState", "ImportedTime", "LastAccessTime", "Md5sum", "Name", "ReleaseDate", "Sha512sum", "Size", "SoftwareAdvisoryUrl", "Source", "Version")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DownloadCount"))) { #optional property not found
            $DownloadCount = $null
        } else {
            $DownloadCount = $JsonParameters.PSobject.Properties["DownloadCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ImportAction"))) { #optional property not found
            $ImportAction = $null
        } else {
            $ImportAction = $JsonParameters.PSobject.Properties["ImportAction"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ImportState"))) { #optional property not found
            $ImportState = $null
        } else {
            $ImportState = $JsonParameters.PSobject.Properties["ImportState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ImportedTime"))) { #optional property not found
            $ImportedTime = $null
        } else {
            $ImportedTime = $JsonParameters.PSobject.Properties["ImportedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastAccessTime"))) { #optional property not found
            $LastAccessTime = $null
        } else {
            $LastAccessTime = $JsonParameters.PSobject.Properties["LastAccessTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Md5sum"))) { #optional property not found
            $Md5sum = $null
        } else {
            $Md5sum = $JsonParameters.PSobject.Properties["Md5sum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ReleaseDate"))) { #optional property not found
            $ReleaseDate = $null
        } else {
            $ReleaseDate = $JsonParameters.PSobject.Properties["ReleaseDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sha512sum"))) { #optional property not found
            $Sha512sum = $null
        } else {
            $Sha512sum = $JsonParameters.PSobject.Properties["Sha512sum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Size"))) { #optional property not found
            $Size = $null
        } else {
            $Size = $JsonParameters.PSobject.Properties["Size"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SoftwareAdvisoryUrl"))) { #optional property not found
            $SoftwareAdvisoryUrl = $null
        } else {
            $SoftwareAdvisoryUrl = $JsonParameters.PSobject.Properties["SoftwareAdvisoryUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Source"))) { #optional property not found
            $Source = $null
        } else {
            $Source = $JsonParameters.PSobject.Properties["Source"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Version"))) { #optional property not found
            $Version = $null
        } else {
            $Version = $JsonParameters.PSobject.Properties["Version"].value
        }

        $PSO = [PSCustomObject]@{
            "Description" = ${Description}
            "DownloadCount" = ${DownloadCount}
            "ImportAction" = ${ImportAction}
            "ImportState" = ${ImportState}
            "ImportedTime" = ${ImportedTime}
            "LastAccessTime" = ${LastAccessTime}
            "Md5sum" = ${Md5sum}
            "Name" = ${Name}
            "ReleaseDate" = ${ReleaseDate}
            "Sha512sum" = ${Sha512sum}
            "Size" = ${Size}
            "SoftwareAdvisoryUrl" = ${SoftwareAdvisoryUrl}
            "Source" = ${Source}
            "Version" = ${Version}
        }

        return $PSO
    }

}

