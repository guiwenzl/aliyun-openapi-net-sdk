/*
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
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.finmall.Model.V20180723;

namespace Aliyun.Acs.finmall.Transform.V20180723
{
    public class AddTrialRecordResponseUnmarshaller
    {
        public static AddTrialRecordResponse Unmarshall(UnmarshallerContext context)
        {
			AddTrialRecordResponse addTrialRecordResponse = new AddTrialRecordResponse();

			addTrialRecordResponse.HttpResponse = context.HttpResponse;
			addTrialRecordResponse.Code = context.StringValue("AddTrialRecord.Code");
			addTrialRecordResponse.Message = context.StringValue("AddTrialRecord.Message");
			addTrialRecordResponse.RequestId = context.StringValue("AddTrialRecord.RequestId");

			AddTrialRecordResponse.AddTrialRecord_Data data = new AddTrialRecordResponse.AddTrialRecord_Data();
			data.CustomId = context.StringValue("AddTrialRecord.Data.CustomId");
			addTrialRecordResponse.Data = data;
        
			return addTrialRecordResponse;
        }
    }
}
