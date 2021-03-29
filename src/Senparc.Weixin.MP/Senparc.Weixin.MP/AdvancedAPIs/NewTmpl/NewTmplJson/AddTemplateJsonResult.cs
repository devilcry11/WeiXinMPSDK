﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2017 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc
    
    文件名：AddJsonResult.cs
    文件功能描述：“从公共模板库中选用模板，到私有模板库中”接口：Add 结果
    
    
    创建标识：Senparc - 20210302

----------------------------------------------------------------*/

using Senparc.Weixin.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs.NewTmpl.NewTmplJson
{
    /// <summary>
    /// “从公共模板库中选用模板，到私有模板库中”接口：AddTemplate 结果
    /// </summary>
    public class AddTemplateJsonResult : WxJsonResult
    {
        /// <summary>
        /// 添加至帐号下的模板id，发送公众号模板消息时所需
        /// </summary>
        public string priTmplId { get; set; }
    }
}