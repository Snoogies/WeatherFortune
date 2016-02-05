using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 236
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                11, // array length: 11
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                11, // array length: 11
                501, // index: 501, string: "base"
                506, // index: 506, string: "clouds"
                513, // index: 513, string: "cod"
                517, // index: 517, string: "coord"
                523, // index: 523, string: "dt"
                526, // index: 526, string: "id"
                529, // index: 529, string: "main"
                534, // index: 534, string: "name"
                539, // index: 539, string: "sys"
                543, // index: 543, string: "weather"
                551, // index: 551, string: "wind"
                11, // array length: 11
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                1, // array length: 1
                556, // index: 556, string: "all"
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                2, // array length: 2
                560, // index: 560, string: "lat"
                564, // index: 564, string: "lon"
                2, // array length: 2
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                7, // array length: 7
                568, // index: 568, string: "grnd_level"
                579, // index: 579, string: "humidity"
                588, // index: 588, string: "pressure"
                597, // index: 597, string: "sea_level"
                607, // index: 607, string: "temp"
                612, // index: 612, string: "temp_max"
                621, // index: 621, string: "temp_min"
                7, // array length: 7
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                4, // array length: 4
                630, // index: 630, string: "country"
                638, // index: 638, string: "message"
                646, // index: 646, string: "sunrise"
                654, // index: 654, string: "sunset"
                4, // array length: 4
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                4, // array length: 4
                661, // index: 661, string: "description"
                673, // index: 673, string: "icon"
                526, // index: 526, string: "id"
                529, // index: 529, string: "main"
                4, // array length: 4
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                2, // array length: 2
                678, // index: 678, string: "deg"
                682, // index: 682, string: "speed"
                2, // array length: 2
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                5, // array length: 5
                688, // index: 688, string: "city"
                693, // index: 693, string: "cnt"
                513, // index: 513, string: "cod"
                697, // index: 697, string: "list"
                638, // index: 638, string: "message"
                5, // array length: 5
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                5, // array length: 5
                517, // index: 517, string: "coord"
                630, // index: 630, string: "country"
                526, // index: 526, string: "id"
                534, // index: 534, string: "name"
                702, // index: 702, string: "population"
                5, // array length: 5
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                13, // array length: 13
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                13, // array length: 13
                713, // index: 713, string: "Time"
                718, // index: 718, string: "_dt"
                722, // index: 722, string: "_time"
                506, // index: 506, string: "clouds"
                678, // index: 678, string: "deg"
                523, // index: 523, string: "dt"
                579, // index: 579, string: "humidity"
                588, // index: 588, string: "pressure"
                728, // index: 728, string: "rain"
                733, // index: 733, string: "snow"
                682, // index: 682, string: "speed"
                607, // index: 607, string: "temp"
                543, // index: 543, string: "weather"
                13, // array length: 13
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                6, // array length: 6
                738, // index: 738, string: "day"
                742, // index: 742, string: "eve"
                746, // index: 746, string: "max"
                750, // index: 750, string: "min"
                754, // index: 754, string: "morn"
                759, // index: 759, string: "night"
                6, // array length: 6
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
                273  // index: 273, string: "http://schemas.datacontract.org/2004/07/WeatherFortune.Model"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContractMap_Hashtable = new byte[0];
        // Count=51
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.CurrentRootObject, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Clouds, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Coord, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Main, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Sys, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[WeatherFortune.Model.Weather, WeatherFortune, Version=1.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                "a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Weather, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Wind, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.ForecastRootObject, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.City, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[WeatherFortune.Model.Day, WeatherFortune, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Day, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Temp, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContracts_Hashtable = new byte[0];
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_classDataContracts_Hashtable = new byte[0];
        // Count=11
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // CurrentRootObject
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 255, // CurrentRootObject
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 255, // CurrentRootObject
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.CurrentRootObject, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.CurrentRootObject, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 13,
                    MemberNamesListIndex = 15,
                    MemberNamespacesListIndex = 27,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 334, // Clouds
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 334, // Clouds
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 334, // Clouds
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Clouds, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Clouds, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 39,
                    ContractNamespacesListIndex = 41,
                    MemberNamesListIndex = 43,
                    MemberNamespacesListIndex = 45,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 341, // Coord
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 341, // Coord
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 341, // Coord
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Coord, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Coord, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 50,
                    MemberNamesListIndex = 52,
                    MemberNamespacesListIndex = 55,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 347, // Main
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 347, // Main
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 347, // Main
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Main, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Main, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 58,
                    ContractNamespacesListIndex = 66,
                    MemberNamesListIndex = 68,
                    MemberNamespacesListIndex = 76,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 352, // Sys
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 352, // Sys
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 352, // Sys
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Sys, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Sys, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 84,
                    ContractNamespacesListIndex = 89,
                    MemberNamesListIndex = 91,
                    MemberNamespacesListIndex = 96,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 371, // Weather
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 371, // Weather
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 371, // Weather
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Weather, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Weather, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 101,
                    ContractNamespacesListIndex = 106,
                    MemberNamesListIndex = 108,
                    MemberNamespacesListIndex = 113,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 379, // Wind
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 379, // Wind
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 379, // Wind
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Wind, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Wind, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 118,
                    ContractNamespacesListIndex = 121,
                    MemberNamesListIndex = 123,
                    MemberNamespacesListIndex = 126,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 384, // ForecastRootObject
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 384, // ForecastRootObject
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 384, // ForecastRootObject
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.ForecastRootObject, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.ForecastRootObject, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 129,
                    ContractNamespacesListIndex = 135,
                    MemberNamesListIndex = 137,
                    MemberNamespacesListIndex = 143,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 403, // City
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 403, // City
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 403, // City
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.City, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.City, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 149,
                    ContractNamespacesListIndex = 155,
                    MemberNamesListIndex = 157,
                    MemberNamespacesListIndex = 163,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 419, // Day
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 419, // Day
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 419, // Day
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Day, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Day, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 169,
                    ContractNamespacesListIndex = 183,
                    MemberNamesListIndex = 185,
                    MemberNamespacesListIndex = 199,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 423, // Temp
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 423, // Temp
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 423, // Temp
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Temp, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Temp, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 213,
                    ContractNamespacesListIndex = 220,
                    MemberNamesListIndex = 222,
                    MemberNamespacesListIndex = 229,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_collectionDataContracts_Hashtable = new byte[0];
        // Count=3
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 356, // ArrayOfWeather
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 356, // ArrayOfWeather
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 356, // ArrayOfWeather
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[WeatherFortune.Model.Weather, WeatherFortune, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[WeatherFortune.Model.Weather, WeatherFortune, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 371, // Weather
                    KeyNameIndex = -1,
                    ItemNameIndex = 371, // Weather
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Weather, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 408, // ArrayOfDay
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        StableNameIndex = 408, // ArrayOfDay
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        TopLevelElementNameIndex = 408, // ArrayOfDay
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/WeatherFortune.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[WeatherFortune.Model.Day, WeatherFortune, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[WeatherFortune.Model.Day, WeatherFortune, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 419, // Day
                    KeyNameIndex = -1,
                    ItemNameIndex = 419, // Day
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("WeatherFortune.Model.Day, WeatherFortune, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 428, // ArrayOfanyType
                        NamespaceIndex = 443, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 428, // ArrayOfanyType
                        StableNameNamespaceIndex = 443, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 428, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 443, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_enumDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_xmlDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_jsonDelegatesList_Hashtable = new byte[0];
        // Count=14
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteCurrentRootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadCurrentRootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteCloudsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadCloudsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type11.WriteCoordToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type10.ReadCoordFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type15.WriteMainToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type14.ReadMainFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type19.WriteSysToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type18.ReadSysFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type24.WriteArrayOfWeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type23.ReadArrayOfWeatherFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type25.ReadArrayOfWeatherFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type29.WriteWeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type28.ReadWeatherFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type33.WriteWindToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type32.ReadWindFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type37.WriteForecastRootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type36.ReadForecastRootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type41.WriteCityToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type40.ReadCityFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type46.WriteArrayOfDayToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type45.ReadArrayOfDayFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type47.ReadArrayOfDayFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type51.WriteDayToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type50.ReadDayFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type55.WriteTempToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type54.ReadTempFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type60.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type59.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type61.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','C','u','r','r','e','n','t','R','o','o','t','O','b','j','e',
            'c','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t',
            '.','o','r','g','/','2','0','0','4','/','0','7','/','W','e','a','t','h','e','r','F','o','r','t','u','n','e','.','M','o',
            'd','e','l','\0','C','l','o','u','d','s','\0','C','o','o','r','d','\0','M','a','i','n','\0','S','y','s','\0','A','r','r','a',
            'y','O','f','W','e','a','t','h','e','r','\0','W','e','a','t','h','e','r','\0','W','i','n','d','\0','F','o','r','e','c','a',
            's','t','R','o','o','t','O','b','j','e','c','t','\0','C','i','t','y','\0','A','r','r','a','y','O','f','D','a','y','\0','D',
            'a','y','\0','T','e','m','p','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/',
            's','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/',
            'S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','b','a','s','e','\0','c','l','o','u',
            'd','s','\0','c','o','d','\0','c','o','o','r','d','\0','d','t','\0','i','d','\0','m','a','i','n','\0','n','a','m','e','\0','s',
            'y','s','\0','w','e','a','t','h','e','r','\0','w','i','n','d','\0','a','l','l','\0','l','a','t','\0','l','o','n','\0','g','r',
            'n','d','_','l','e','v','e','l','\0','h','u','m','i','d','i','t','y','\0','p','r','e','s','s','u','r','e','\0','s','e','a',
            '_','l','e','v','e','l','\0','t','e','m','p','\0','t','e','m','p','_','m','a','x','\0','t','e','m','p','_','m','i','n','\0',
            'c','o','u','n','t','r','y','\0','m','e','s','s','a','g','e','\0','s','u','n','r','i','s','e','\0','s','u','n','s','e','t',
            '\0','d','e','s','c','r','i','p','t','i','o','n','\0','i','c','o','n','\0','d','e','g','\0','s','p','e','e','d','\0','c','i',
            't','y','\0','c','n','t','\0','l','i','s','t','\0','p','o','p','u','l','a','t','i','o','n','\0','T','i','m','e','\0','_','d',
            't','\0','_','t','i','m','e','\0','r','a','i','n','\0','s','n','o','w','\0','d','a','y','\0','e','v','e','\0','m','a','x','\0',
            'm','i','n','\0','m','o','r','n','\0','n','i','g','h','t','\0'};
    }
}
