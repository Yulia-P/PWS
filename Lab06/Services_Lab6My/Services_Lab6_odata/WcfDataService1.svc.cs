//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace Services_Lab6_odata
{
    public class WcfDataService1 : EntityFrameworkDataService<Services_Lab6Entities2>
    {
            // This method is called only once to initialize service-wide policies.
            public static void InitializeService(DataServiceConfiguration config)
            {
                config.SetEntitySetAccessRule("*", EntitySetRights.All);
                config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
                config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
            }
        }
    }
