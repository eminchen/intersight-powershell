#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

Describe -tag 'Intersight' -name 'IntersightSoftwareHyperflexDistributableRelationship' {
    Context 'IntersightSoftwareHyperflexDistributableRelationship' {
        It 'Initialize-IntersightSoftwareHyperflexDistributableRelationship' {
            # a simple test to create an object
            #$NewObject = Initialize-IntersightSoftwareHyperflexDistributableRelationship -ClassId "TEST_VALUE" -ObjectType "TEST_VALUE" -Moid "TEST_VALUE" -Selector "TEST_VALUE" -Link "TEST_VALUE" -AccountMoid "TEST_VALUE" -CreateTime "TEST_VALUE" -DomainGroupMoid "TEST_VALUE" -ModTime "TEST_VALUE" -Owners "TEST_VALUE" -SharedScope "TEST_VALUE" -Tags "TEST_VALUE" -VersionContext "TEST_VALUE" -Ancestors "TEST_VALUE" -Parent "TEST_VALUE" -PermissionResources "TEST_VALUE" -DisplayNames "TEST_VALUE" -Description "TEST_VALUE" -DownloadCount "TEST_VALUE" -ImportAction "TEST_VALUE" -ImportState "TEST_VALUE" -ImportedTime "TEST_VALUE" -LastAccessTime "TEST_VALUE" -Md5sum "TEST_VALUE" -Name "TEST_VALUE" -ReleaseDate "TEST_VALUE" -Sha512sum "TEST_VALUE" -Size "TEST_VALUE" -SoftwareAdvisoryUrl "TEST_VALUE" -Source "TEST_VALUE" -Version "TEST_VALUE" -BundleType "TEST_VALUE" -ComponentMeta "TEST_VALUE" -Guid "TEST_VALUE" -Mdfid "TEST_VALUE" -Model "TEST_VALUE" -PlatformType "TEST_VALUE" -RecommendedBuild "TEST_VALUE" -ReleaseNotesUrl "TEST_VALUE" -SoftwareTypeId "TEST_VALUE" -SupportedModels "TEST_VALUE" -Vendor "TEST_VALUE" -DistributableMetas "TEST_VALUE" -Release "TEST_VALUE" -Catalog "TEST_VALUE"
            #$NewObject | Should -BeOfType SoftwareHyperflexDistributableRelationship
            #$NewObject.property | Should -Be 0
        }
    }
}
