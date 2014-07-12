﻿/**
* author:xishuai
* address:https://www.github.com/yuezhongxin/MessageManager
**/

namespace MessageManager.Domain.ValueObject
{
    public class Recipient : IContact
    {
        public Recipient(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}