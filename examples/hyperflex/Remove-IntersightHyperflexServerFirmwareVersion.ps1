
#Get the HyperflexServerFirmwareVersion to delete
$HyperflexServerFirmwareVersion = Remove-IntersightHyperflexServerFirmwareVersion -Name HyperflexServerFirmwareVersionName
$HyperflexServerFirmwareVersion | Remove-IntersightHyperflexServerFirmwareVersion

#Remove the server profile by Moid.
Remove-IntersightHyperflexServerFirmwareVersion -Moid 123bc2222287wee
