/*
 * Copyright 2020 G42 Technologies Co.,Ltd.
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;

namespace G42Cloud.SDK.Core.Auth
{
    public class EnvCredentials
    {
        private const string AkEnvName = "G42CLOUD_SDK_AK";
        private const string SkEnvName = "G42CLOUD_SDK_SK";
        private const string ProjectIdEnvName = "G42CLOUD_SDK_PROJECT_ID";
        private const string DomainIdEnvName = "G42CLOUD_SDK_DOMAIN_ID";

        private const string BasicCredentialsType = "BasicCredentials";
        private const string GlobalCredentialsType = "GlobalCredentials";

        public static Credentials LoadCredentialsFromEnv(string defaultType)
        {
            var ak = Environment.GetEnvironmentVariable(AkEnvName);
            var sk = Environment.GetEnvironmentVariable(SkEnvName);

            if (Equals(BasicCredentialsType, defaultType))
            {
                var projectId = Environment.GetEnvironmentVariable(ProjectIdEnvName);
                return new BasicCredentials(ak, sk, projectId);
            }

            if (Equals(GlobalCredentialsType, defaultType))
            {
                var domainId = Environment.GetEnvironmentVariable(DomainIdEnvName);
                return new GlobalCredentials(ak, sk, domainId);
            }

            return null;
        }
    }
}