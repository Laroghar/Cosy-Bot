//namespace CosyBot
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Text;
//    using System.Configuration;
//    using System.Globalization;
//    using System.ComponentModel;
//    using System.Collections.Specialized;
 
//    #region CommandsSection class

//    public sealed class CommandsSection : ConfigurationSection
//    {

//        public CommandsSection()
//        {

//        }


//        [ConfigurationProperty("commandName",
//         DefaultValue = "",
//         IsRequired = true,
//         IsKey = true)]
//        public string CommandName
//        {
//            get
//            {
//                return (string)this["commandName"];
//            }
//            set
//            {
//                this["commandName"] = value;
//            }
//        }

//        [ConfigurationProperty("class",
//            DefaultValue = "",
//            IsRequired = true)]
//        public string Class
//        {
//            get
//            {
//                return (string)this["class"];
//            }
//            set
//            {
//                this["class"] = value;
//            }
//        }
//    }

//    #endregion

//}