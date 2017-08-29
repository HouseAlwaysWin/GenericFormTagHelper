﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTagHelper.MethodHelpers
{
    public static class JsonDeserialize
    {
        public static Dictionary<string, string> JsonDeserializeConvert_Dss(
           string classString)
        {
            if (!String.IsNullOrEmpty(classString))
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(classString);
            }
            return new Dictionary<string, string>();
        }

        public static Dictionary<string, Dictionary<string, string>> JsonDeserializeConvert_DsDss(
            string attributeString)
        {
            if (!String.IsNullOrEmpty(attributeString))
            {
                return JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(attributeString);
            }
            return new Dictionary<string, Dictionary<string, string>>();
        }

        public static List<Dictionary<string, string>> JsonDeserializeConvert_LDss(
          string propertyString)
        {
            if (!String.IsNullOrEmpty(propertyString))
            {
                return JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(propertyString);
            }
            return new List<Dictionary<string, string>>();
        }

        public static List<string> JsonDeserializeConvert_Ls(
                  string propertyString)
        {
            if (!String.IsNullOrEmpty(propertyString))
            {
                return JsonConvert.DeserializeObject<List<string>>(propertyString);
            }
            return new List<string>();
        }
 
    }
}