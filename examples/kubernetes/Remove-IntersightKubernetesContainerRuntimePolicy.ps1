
#Get the KubernetesContainerRuntimePolicy to delete
$KubernetesContainerRuntimePolicy = Remove-IntersightKubernetesContainerRuntimePolicy -Name KubernetesContainerRuntimePolicyName
$KubernetesContainerRuntimePolicy | Remove-IntersightKubernetesContainerRuntimePolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesContainerRuntimePolicy -Moid 123bc2222287wee
