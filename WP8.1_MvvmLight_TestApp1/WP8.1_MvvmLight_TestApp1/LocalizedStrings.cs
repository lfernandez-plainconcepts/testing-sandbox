﻿using WP8._1_MvvmLight_TestApp1.Resources;

namespace WP8._1_MvvmLight_TestApp1
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}