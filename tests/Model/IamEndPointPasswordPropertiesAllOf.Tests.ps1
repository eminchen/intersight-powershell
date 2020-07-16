#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

Describe -tag 'Intersight' -name 'IntersightIamEndPointPasswordPropertiesAllOf' {
    Context 'IntersightIamEndPointPasswordPropertiesAllOf' {
        It 'Initialize-IntersightIamEndPointPasswordPropertiesAllOf' {
            # a simple test to create an object
            #$NewObject = Initialize-IntersightIamEndPointPasswordPropertiesAllOf -EnablePasswordExpiry "TEST_VALUE" -EnforceStrongPassword "TEST_VALUE" -ForceSendPassword "TEST_VALUE" -GracePeriod "TEST_VALUE" -NotificationPeriod "TEST_VALUE" -PasswordExpiryDuration "TEST_VALUE" -PasswordHistory "TEST_VALUE"
            #$NewObject | Should -BeOfType IamEndPointPasswordPropertiesAllOf
            #$NewObject.property | Should -Be 0
        }
    }
}
