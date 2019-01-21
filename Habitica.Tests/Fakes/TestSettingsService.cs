using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using TIKSN.Settings;

namespace TIKSN.Habitica.Tests.Fakes
{
    public class TestSettingsService : ISettingsService
    {
        private readonly IConfigurationRoot _configurationRoot;

        public TestSettingsService(IConfigurationRoot configurationRoot)
        {
            _configurationRoot = configurationRoot ?? throw new ArgumentNullException(nameof(configurationRoot));
        }

        public T GetLocalSetting<T>(string name, T defaultValue)
        {
            return _configurationRoot.GetValue<T>(name);
        }

        public T GetRoamingSetting<T>(string name, T defaultValue)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<string> ListLocalSetting()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<string> ListRoamingSetting()
        {
            throw new NotImplementedException();
        }

        public void RemoveLocalSetting(string name)
        {
            throw new NotImplementedException();
        }

        public void RemoveRoamingSetting(string name)
        {
            throw new NotImplementedException();
        }

        public void SetLocalSetting<T>(string name, T value)
        {
            _configurationRoot[name] = value.ToString();
        }

        public void SetRoamingSetting<T>(string name, T value)
        {
            throw new NotImplementedException();
        }
    }
}