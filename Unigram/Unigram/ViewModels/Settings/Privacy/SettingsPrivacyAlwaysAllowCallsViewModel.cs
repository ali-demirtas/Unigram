﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Td.Api;
using Unigram.Services;

namespace Unigram.ViewModels.Settings.Privacy
{
    public class SettingsPrivacyAlwaysAllowCallsViewModel : SettingsPrivacyAlwaysViewModelBase
    {
        public SettingsPrivacyAlwaysAllowCallsViewModel(IProtoService protoService, ICacheService cacheService, ISettingsService settingsService, IEventAggregator aggregator)
            : base(protoService, cacheService, settingsService, aggregator, new UserPrivacySettingAllowCalls())
        {
        }

        public override string Title => Strings.Resources.AlwaysAllow;
    }
}
