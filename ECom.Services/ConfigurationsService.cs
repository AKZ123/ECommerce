﻿using ECom.Database;
using ECom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Services
{
    public class ConfigurationsService
    {
        #region Singleton
        public static ConfigurationsService Instance
        {
            get
            {
                if (instance == null) instance = new ConfigurationsService();
                return instance;
            }
        }
        private static ConfigurationsService instance { get; set; }
        private ConfigurationsService()
        {

        }
        #endregion
        public Config GetConfig(string Key)
        {
            using (var context = new CBContext())
            {
                return context.Configurations.Find(Key);
            }
        }
    }
}
