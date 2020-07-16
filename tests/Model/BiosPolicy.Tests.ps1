#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

Describe -tag 'Intersight' -name 'IntersightBiosPolicy' {
    Context 'IntersightBiosPolicy' {
        It 'Initialize-IntersightBiosPolicy' {
            # a simple test to create an object
            #$NewObject = Initialize-IntersightBiosPolicy -AccountMoid "TEST_VALUE" -ClassId "TEST_VALUE" -CreateTime "TEST_VALUE" -DomainGroupMoid "TEST_VALUE" -ModTime "TEST_VALUE" -Moid "TEST_VALUE" -ObjectType "TEST_VALUE" -Owners "TEST_VALUE" -SharedScope "TEST_VALUE" -Tags "TEST_VALUE" -VersionContext "TEST_VALUE" -Ancestors "TEST_VALUE" -Parent "TEST_VALUE" -PermissionResources "TEST_VALUE" -DisplayNames "TEST_VALUE" -Description "TEST_VALUE" -Name "TEST_VALUE" -AcsControlGpu1state "TEST_VALUE" -AcsControlGpu2state "TEST_VALUE" -AcsControlGpu3state "TEST_VALUE" -AcsControlGpu4state "TEST_VALUE" -AcsControlGpu5state "TEST_VALUE" -AcsControlGpu6state "TEST_VALUE" -AcsControlGpu7state "TEST_VALUE" -AcsControlGpu8state "TEST_VALUE" -AcsControlSlot11state "TEST_VALUE" -AcsControlSlot12state "TEST_VALUE" -AcsControlSlot13state "TEST_VALUE" -AcsControlSlot14state "TEST_VALUE" -AdjacentCacheLinePrefetch "TEST_VALUE" -AllUsbDevices "TEST_VALUE" -Altitude "TEST_VALUE" -AspmSupport "TEST_VALUE" -AssertNmiOnPerr "TEST_VALUE" -AssertNmiOnSerr "TEST_VALUE" -AutoCcState "TEST_VALUE" -AutonumousCstateEnable "TEST_VALUE" -BaudRate "TEST_VALUE" -BmeDmaMitigation "TEST_VALUE" -BootOptionNumRetry "TEST_VALUE" -BootOptionReCoolDown "TEST_VALUE" -BootOptionRetry "TEST_VALUE" -BootPerformanceMode "TEST_VALUE" -CbsCmnCpuCpb "TEST_VALUE" -CbsCmnCpuGenDowncoreCtrl "TEST_VALUE" -CbsCmnCpuGlobalCstateCtrl "TEST_VALUE" -CbsCmnCpuL1streamHwPrefetcher "TEST_VALUE" -CbsCmnCpuL2streamHwPrefetcher "TEST_VALUE" -CbsCmnDeterminismSlider "TEST_VALUE" -CbsCmnGnbNbIommu "TEST_VALUE" -CbsCmnMemCtrlBankGroupSwapDdr4 "TEST_VALUE" -CbsCmnMemMapBankInterleaveDdr4 "TEST_VALUE" -CbsCmncTdpCtl "TEST_VALUE" -CbsDfCmnMemIntlv "TEST_VALUE" -CbsDfCmnMemIntlvSize "TEST_VALUE" -CdnEnable "TEST_VALUE" -CdnSupport "TEST_VALUE" -ChannelInterLeave "TEST_VALUE" -CiscoAdaptiveMemTraining "TEST_VALUE" -CiscoDebugLevel "TEST_VALUE" -CiscoOpromLaunchOptimization "TEST_VALUE" -CkeLowPolicy "TEST_VALUE" -ClosedLoopThermThrotl "TEST_VALUE" -CmciEnable "TEST_VALUE" -ConfigTdp "TEST_VALUE" -ConfigTdpLevel "TEST_VALUE" -ConsoleRedirection "TEST_VALUE" -CoreMultiProcessing "TEST_VALUE" -CpuEnergyPerformance "TEST_VALUE" -CpuFrequencyFloor "TEST_VALUE" -CpuPerformance "TEST_VALUE" -CpuPowerManagement "TEST_VALUE" -CrQos "TEST_VALUE" -CrfastgoConfig "TEST_VALUE" -DcpmmFirmwareDowngrade "TEST_VALUE" -DemandScrub "TEST_VALUE" -DirectCacheAccess "TEST_VALUE" -DramClockThrottling "TEST_VALUE" -DramRefreshRate "TEST_VALUE" -EnableClockSpreadSpec "TEST_VALUE" -EnergyEfficientTurbo "TEST_VALUE" -EngPerfTuning "TEST_VALUE" -EnhancedIntelSpeedStepTech "TEST_VALUE" -EppProfile "TEST_VALUE" -ExecuteDisableBit "TEST_VALUE" -ExtendedApic "TEST_VALUE" -FlowControl "TEST_VALUE" -Frb2enable "TEST_VALUE" -HardwarePrefetch "TEST_VALUE" -HwpmEnable "TEST_VALUE" -ImcInterleave "TEST_VALUE" -IntelHyperThreadingTech "TEST_VALUE" -IntelSpeedSelect "TEST_VALUE" -IntelTurboBoostTech "TEST_VALUE" -IntelVirtualizationTechnology "TEST_VALUE" -IntelVtForDirectedIo "TEST_VALUE" -IntelVtdCoherencySupport "TEST_VALUE" -IntelVtdInterruptRemapping "TEST_VALUE" -IntelVtdPassThroughDmaSupport "TEST_VALUE" -IntelVtdatsSupport "TEST_VALUE" -IohErrorEnable "TEST_VALUE" -IohResource "TEST_VALUE" -IpPrefetch "TEST_VALUE" -Ipv4pxe "TEST_VALUE" -Ipv6pxe "TEST_VALUE" -KtiPrefetch "TEST_VALUE" -LegacyOsRedirection "TEST_VALUE" -LegacyUsbSupport "TEST_VALUE" -LlcPrefetch "TEST_VALUE" -LomPort0state "TEST_VALUE" -LomPort1state "TEST_VALUE" -LomPort2state "TEST_VALUE" -LomPort3state "TEST_VALUE" -LomPortsAllState "TEST_VALUE" -LvDdrMode "TEST_VALUE" -MakeDeviceNonBootable "TEST_VALUE" -MemoryInterLeave "TEST_VALUE" -MemoryMappedIoAbove4gb "TEST_VALUE" -MemorySizeLimit "TEST_VALUE" -MirroringMode "TEST_VALUE" -MmcfgBase "TEST_VALUE" -NetworkStack "TEST_VALUE" -NumaOptimized "TEST_VALUE" -NvmdimmPerformConfig "TEST_VALUE" -Onboard10gbitLom "TEST_VALUE" -OnboardGbitLom "TEST_VALUE" -OnboardScuStorageSupport "TEST_VALUE" -OnboardScuStorageSwStack "TEST_VALUE" -OsBootWatchdogTimer "TEST_VALUE" -OsBootWatchdogTimerPolicy "TEST_VALUE" -OsBootWatchdogTimerTimeout "TEST_VALUE" -OutOfBandMgmtPort "TEST_VALUE" -PackageCstateLimit "TEST_VALUE" -PartialMirrorModeConfig "TEST_VALUE" -PartialMirrorPercent "TEST_VALUE" -PartialMirrorValue1 "TEST_VALUE" -PartialMirrorValue2 "TEST_VALUE" -PartialMirrorValue3 "TEST_VALUE" -PartialMirrorValue4 "TEST_VALUE" -PatrolScrub "TEST_VALUE" -PatrolScrubDuration "TEST_VALUE" -PcIeRasSupport "TEST_VALUE" -PcIeSsdHotPlugSupport "TEST_VALUE" -PchUsb30mode "TEST_VALUE" -PciOptionRoMs "TEST_VALUE" -PciRomClp "TEST_VALUE" -PcieAriSupport "TEST_VALUE" -PciePllSsc "TEST_VALUE" -PcieSlotMstorraidOptionRom "TEST_VALUE" -PcieSlotNvme1linkSpeed "TEST_VALUE" -PcieSlotNvme1optionRom "TEST_VALUE" -PcieSlotNvme2linkSpeed "TEST_VALUE" -PcieSlotNvme2optionRom "TEST_VALUE" -PcieSlotNvme3linkSpeed "TEST_VALUE" -PcieSlotNvme3optionRom "TEST_VALUE" -PcieSlotNvme4linkSpeed "TEST_VALUE" -PcieSlotNvme4optionRom "TEST_VALUE" -PcieSlotNvme5linkSpeed "TEST_VALUE" -PcieSlotNvme5optionRom "TEST_VALUE" -PcieSlotNvme6linkSpeed "TEST_VALUE" -PcieSlotNvme6optionRom "TEST_VALUE" -PopSupport "TEST_VALUE" -PostErrorPause "TEST_VALUE" -ProcessorC1e "TEST_VALUE" -ProcessorC3report "TEST_VALUE" -ProcessorC6report "TEST_VALUE" -ProcessorCstate "TEST_VALUE" -Psata "TEST_VALUE" -PstateCoordType "TEST_VALUE" -PuttyKeyPad "TEST_VALUE" -PwrPerfTuning "TEST_VALUE" -QpiLinkFrequency "TEST_VALUE" -QpiLinkSpeed "TEST_VALUE" -QpiSnoopMode "TEST_VALUE" -RankInterLeave "TEST_VALUE" -RedirectionAfterPost "TEST_VALUE" -SataModeSelect "TEST_VALUE" -SelectMemoryRasConfiguration "TEST_VALUE" -SelectPprType "TEST_VALUE" -SerialPortAenable "TEST_VALUE" -SinglePctlEnable "TEST_VALUE" -Slot10linkSpeed "TEST_VALUE" -Slot10state "TEST_VALUE" -Slot11linkSpeed "TEST_VALUE" -Slot11state "TEST_VALUE" -Slot12linkSpeed "TEST_VALUE" -Slot12state "TEST_VALUE" -Slot13state "TEST_VALUE" -Slot14state "TEST_VALUE" -Slot1linkSpeed "TEST_VALUE" -Slot1state "TEST_VALUE" -Slot2linkSpeed "TEST_VALUE" -Slot2state "TEST_VALUE" -Slot3linkSpeed "TEST_VALUE" -Slot3state "TEST_VALUE" -Slot4linkSpeed "TEST_VALUE" -Slot4state "TEST_VALUE" -Slot5linkSpeed "TEST_VALUE" -Slot5state "TEST_VALUE" -Slot6linkSpeed "TEST_VALUE" -Slot6state "TEST_VALUE" -Slot7linkSpeed "TEST_VALUE" -Slot7state "TEST_VALUE" -Slot8linkSpeed "TEST_VALUE" -Slot8state "TEST_VALUE" -Slot9linkSpeed "TEST_VALUE" -Slot9state "TEST_VALUE" -SlotFlomLinkSpeed "TEST_VALUE" -SlotFrontNvme1linkSpeed "TEST_VALUE" -SlotFrontNvme2linkSpeed "TEST_VALUE" -SlotFrontSlot5linkSpeed "TEST_VALUE" -SlotFrontSlot6linkSpeed "TEST_VALUE" -SlotGpu1state "TEST_VALUE" -SlotGpu2state "TEST_VALUE" -SlotGpu3state "TEST_VALUE" -SlotGpu4state "TEST_VALUE" -SlotGpu5state "TEST_VALUE" -SlotGpu6state "TEST_VALUE" -SlotGpu7state "TEST_VALUE" -SlotGpu8state "TEST_VALUE" -SlotHbaLinkSpeed "TEST_VALUE" -SlotHbaState "TEST_VALUE" -SlotLom1link "TEST_VALUE" -SlotLom2link "TEST_VALUE" -SlotMezzState "TEST_VALUE" -SlotMlomLinkSpeed "TEST_VALUE" -SlotMlomState "TEST_VALUE" -SlotMraidLinkSpeed "TEST_VALUE" -SlotMraidState "TEST_VALUE" -SlotN10state "TEST_VALUE" -SlotN11state "TEST_VALUE" -SlotN12state "TEST_VALUE" -SlotN13state "TEST_VALUE" -SlotN14state "TEST_VALUE" -SlotN15state "TEST_VALUE" -SlotN16state "TEST_VALUE" -SlotN17state "TEST_VALUE" -SlotN18state "TEST_VALUE" -SlotN19state "TEST_VALUE" -SlotN1state "TEST_VALUE" -SlotN20state "TEST_VALUE" -SlotN21state "TEST_VALUE" -SlotN22state "TEST_VALUE" -SlotN23state "TEST_VALUE" -SlotN24state "TEST_VALUE" -SlotN2state "TEST_VALUE" -SlotN3state "TEST_VALUE" -SlotN4state "TEST_VALUE" -SlotN5state "TEST_VALUE" -SlotN6state "TEST_VALUE" -SlotN7state "TEST_VALUE" -SlotN8state "TEST_VALUE" -SlotN9state "TEST_VALUE" -SlotRaidLinkSpeed "TEST_VALUE" -SlotRaidState "TEST_VALUE" -SlotRearNvme1linkSpeed "TEST_VALUE" -SlotRearNvme1state "TEST_VALUE" -SlotRearNvme2linkSpeed "TEST_VALUE" -SlotRearNvme2state "TEST_VALUE" -SlotRearNvme3state "TEST_VALUE" -SlotRearNvme4state "TEST_VALUE" -SlotRearNvme5state "TEST_VALUE" -SlotRearNvme6state "TEST_VALUE" -SlotRearNvme7state "TEST_VALUE" -SlotRearNvme8state "TEST_VALUE" -SlotRiser1linkSpeed "TEST_VALUE" -SlotRiser1slot1linkSpeed "TEST_VALUE" -SlotRiser1slot2linkSpeed "TEST_VALUE" -SlotRiser1slot3linkSpeed "TEST_VALUE" -SlotRiser2linkSpeed "TEST_VALUE" -SlotRiser2slot4linkSpeed "TEST_VALUE" -SlotRiser2slot5linkSpeed "TEST_VALUE" -SlotRiser2slot6linkSpeed "TEST_VALUE" -SlotSasState "TEST_VALUE" -SlotSsdSlot1linkSpeed "TEST_VALUE" -SlotSsdSlot2linkSpeed "TEST_VALUE" -Smee "TEST_VALUE" -SmtMode "TEST_VALUE" -Snc "TEST_VALUE" -SnoopyModeFor2lm "TEST_VALUE" -SnoopyModeForAd "TEST_VALUE" -SparingMode "TEST_VALUE" -SrIov "TEST_VALUE" -StreamerPrefetch "TEST_VALUE" -SvmMode "TEST_VALUE" -TerminalType "TEST_VALUE" -TpmControl "TEST_VALUE" -TpmSupport "TEST_VALUE" -TxtSupport "TEST_VALUE" -UcsmBootOrderRule "TEST_VALUE" -UfsDisable "TEST_VALUE" -UsbEmul6064 "TEST_VALUE" -UsbPortFront "TEST_VALUE" -UsbPortInternal "TEST_VALUE" -UsbPortKvm "TEST_VALUE" -UsbPortRear "TEST_VALUE" -UsbPortSdCard "TEST_VALUE" -UsbPortVmedia "TEST_VALUE" -UsbXhciSupport "TEST_VALUE" -VgaPriority "TEST_VALUE" -VmdEnable "TEST_VALUE" -WorkLoadConfig "TEST_VALUE" -XptPrefetch "TEST_VALUE" -Organization "TEST_VALUE" -Profiles "TEST_VALUE"
            #$NewObject | Should -BeOfType BiosPolicy
            #$NewObject.property | Should -Be 0
        }
    }
}
