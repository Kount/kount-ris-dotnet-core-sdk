﻿
namespace KountRisCoreTest
{
    using Kount.Ris;
    using Xunit;



    public class ConfigurationTest
    {
        public Configuration SUT;

        
        public ConfigurationTest()
        {
            SUT = Configuration.FromAppSettings();
        }

         [Fact]
        public void FromAppSettings_assigns_Connect_Timeout()
        {
            Assert.Equal("10000", SUT.ConnectTimeout);
        }

         [Fact]
        public void FromAppSettings_assigns_MerchantId()
        {
            Assert.Equal("000000", SUT.MerchantId);
        }

         [Fact]
        public void FromAppSettings_assigns_API_Key()
        {
            Assert.Equal("", SUT.ApiKey);
        }

         [Fact]
        public void FromAppSettings_assigns_Version()
        {
            Assert.Equal("0700", SUT.Version);
        }

         [Fact]
        public void FromAppSettings_assigns_Url()
        {
            Assert.Equal("https://risk.beta.kount.net", SUT.URL);
        }

         [Fact]
        public void FromAppSettings_assigns_CertificateFile()
        {
            Assert.Equal("certificate.pfx", SUT.CertificateFile);
        }

         [Fact]
        public void FromAppSettings_assigns_PrivateKeyPassword()
        {
            Assert.Equal("11111111111111111", SUT.PrivateKeyPassword);
        }

         [Fact]
        public void FromAppSettings_assigns_ConfigKey()
        {
            Assert.NotNull(SUT.ConfigKey);
        }
    }
}