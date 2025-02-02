﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Client;
using System.Security;
using System.Security.Cryptography;
using System.Net;

namespace Intersight.PowerShell
{
    public class ConfigInfo
    {
        public string BasePath { get; set; }
        public string ApiKeyId { get; set; }
        public string ApiKeyFilePath { get; set; }
        public SecureString ApiKeyPassPhrase { get; set; }
        public WebProxy Proxy { get; set; }
        public string HashAlgorithm { get; set; }
        public List<string> HttpSigningHeader { get; set; }
        public int SignatureValidityPeriod { get; set; }

    }
    [Cmdlet(VerbsCommon.Set, "IntersightConfiguration")]
    public class SetConfigurationCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string BasePath { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string ApiKeyId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string ApiKeyFilePath { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public String ApiKeyPassPhrase { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public WebProxy Proxy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        [ValidateSet("sha256", "sha512")]
        public string HashAlgorithm { get; set; } = "sha256";

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public List<string> HttpSigningHeader { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public int SignatureValidityPeriod { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter SkipCertificateCheck { get; set; }

        protected override void ProcessRecord()
        {
            HttpSigningConfiguration httpConfig = new HttpSigningConfiguration()
            {
                KeyId = this.ApiKeyId,
                KeyFilePath = this.ApiKeyFilePath,
                HttpSigningHeader = this.HttpSigningHeader
            };

            if (this.HttpSigningHeader.Contains("(expires)"))
            {
                if (SignatureValidityPeriod <= 0)
                {
                    throw new Exception("SignatureValidityPeriod must be greater than 0 seconds.");
                }
                else
                {
                    httpConfig.SignatureValidityPeriod = SignatureValidityPeriod;
                }
            }

            if (HashAlgorithm.Equals("sha256"))
            {
                httpConfig.HashAlgorithm = HashAlgorithmName.SHA256;
            }
            else if (HashAlgorithm.Equals("sha512"))
            {
                httpConfig.HashAlgorithm = HashAlgorithmName.SHA512;
            }

            if (!string.IsNullOrEmpty(ApiKeyPassPhrase))
            {
                var secStr = new SecureString();
                foreach (char ch in ApiKeyPassPhrase)
                {
                    secStr.AppendChar(ch);
                }
                httpConfig.KeyPassPhrase = secStr;
            }

            Configuration config = new Configuration()
            {
                BasePath = BasePath,
                HttpSigningConfiguration = httpConfig
            };
            CmdletBase.Config = config;
            if (Proxy != null)
            {
                config.Proxy = this.Proxy;
            }

            if (SkipCertificateCheck.IsPresent)
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            }
        }
    }

    [Cmdlet(VerbsCommon.Get, "IntersightConfiguration")]
    public class GetConfigurationCmldet : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            if (CmdletBase.Config != null)
            {
                ConfigInfo configInfo = new ConfigInfo();
                configInfo.BasePath = CmdletBase.Config.BasePath;
                if (CmdletBase.Config.HttpSigningConfiguration != null)
                {
                    configInfo.ApiKeyId = CmdletBase.Config.HttpSigningConfiguration.KeyId;
                    configInfo.ApiKeyFilePath = CmdletBase.Config.HttpSigningConfiguration.KeyFilePath;
                    configInfo.ApiKeyPassPhrase = CmdletBase.Config.HttpSigningConfiguration.KeyPassPhrase;
                    configInfo.HttpSigningHeader = CmdletBase.Config.HttpSigningConfiguration.HttpSigningHeader;
                    configInfo.HashAlgorithm = CmdletBase.Config.HttpSigningConfiguration.HashAlgorithm.Name;
                    configInfo.SignatureValidityPeriod = CmdletBase.Config.HttpSigningConfiguration.SignatureValidityPeriod;
                }

                configInfo.Proxy = CmdletBase.Config.Proxy;
                WriteObject(configInfo);
            }
        }
    }
}
