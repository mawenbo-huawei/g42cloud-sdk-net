﻿/*
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

namespace G42Cloud.SDK.Core
{
    public class FormDataPart<T>
    {
        private T _value;

        public FormDataPart(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }

        public FormDataPart<T> WithValue(T value)
        {
            _value = value;
            return this;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

    }
}
