using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using System;
using Microsoft.AspNetCore.Hosting.Server;

namespace TodoApi.Models;

public class TodoItem
{

    public static object sql()
    {
        Uri url = UrlBuilder.Build("Owen.OPCNet.DA.1");
        using (var server = new OpcDaServer(url))
        {
            string[] fetch = new string[68]; //x2
            server.Connect();
            OpcDaGroup group = server.AddGroup("Узел1");
            group.IsActive = true;         
            var definition1 = new OpcDaItemDefinition
            {
                ItemId = "Узел1.M34tempVlaj.Группа тегов1.M34temp",
                IsActive = true,
                AccessPath = "M34"
            };
            var definition2 = new OpcDaItemDefinition
            {
                ItemId = "Узел1.M34tempVlaj.Группа тегов1.M34vlaj",
                IsActive = true,
                AccessPath = "18-20/M34в"
            };
            var definition3 = new OpcDaItemDefinition
            {
                ItemId = "Узел1.M35tempVlaj.Группа тегов1.M35temp",
                IsActive = true,
                AccessPath = "M35"
            };
            var definition4 = new OpcDaItemDefinition
            {
                ItemId = "Узел1.M35tempVlaj.Группа тегов1.M35vlaj",
                IsActive = true,
                AccessPath = "18-20/M35в"
            };
            var definition5 = new OpcDaItemDefinition
            {
                ItemId = "Узел1.P22tempVlaj.Группа тегов1.P22temp",
                IsActive = true,
                AccessPath = "П22"
            };
            var definition6 = new OpcDaItemDefinition
            {
                ItemId = "Узел1.P22tempVlaj.Группа тегов1.P22vlaj",
                IsActive = true,
                AccessPath = "19-22/П22в"
            };
            var definition7 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.П7-8-9-М2.Voler'sTemperatureV12-13.V12Temp",
                IsActive = true,
                AccessPath = "В12"
            };
            var definition8 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.П7-8-9-М2.Voler'sTemperatureV12-13.V12vlaj",
                IsActive = true,
                AccessPath = "24-26/В12в"
            };
            var definition9 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.П7-8-9-М2.Voler'sTemperatureV12-13.V13Temp",
                IsActive = true,
                AccessPath = "В13"
            };
            var definition10 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.П7-8-9-М2.Voler'sTemperatureV12-13.V13Vlaj",
                IsActive = true,
                AccessPath = "24-26/В13в"
            };
            var definition11 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.P10-11-deoniz.Группа тегов1.V1temp",
                IsActive = true,
                AccessPath = "В1"
            };
            var definition12 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.P10-11-deoniz.Группа тегов1.V1vlaj",
                IsActive = true,
                AccessPath = "24-26/В1в"
            };
            var definition13 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.P10-11-deoniz.Группа тегов1.V2temp",
                IsActive = true,
                AccessPath = "В2"
            };
            var definition14 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.P10-11-deoniz.Группа тегов1.V2vlaj",
                IsActive = true,
                AccessPath = "24-26/В2в"
            };
            var definition15 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.МВ210-101 p11.Оперативные параметры.Измеренное значение.П11 temp",
                IsActive = true,
                AccessPath = "П11"
            };
            var definition16 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.МВ210-101 p11.Оперативные параметры.Измеренное значение.П11 Rh",
                IsActive = true,
                AccessPath = "24-26/П11в"
            };
            var definition17 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.sb1t",
                IsActive = true,
                AccessPath = "ДЖ1"
            };
            var definition18 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.sb1v",
                IsActive = true,
                AccessPath = "24-26/ДЖ1в"
            };
            var definition19 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.sb2t",
                IsActive = true,
                AccessPath = "ДЖ2"
            };
            var definition20 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.sb2v",
                IsActive = true,
                AccessPath = "24-26/ДЖ2в"
            };
            var definition21 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.V14t",
                IsActive = true,
                AccessPath = "В14"
            };
            var definition22 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.V14v",
                IsActive = true,
                AccessPath = "24-26/В14в"
            };
            var definition23 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.V15t",
                IsActive = true,
                AccessPath = "В15"
            };
            var definition24 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.V15v",
                IsActive = true,
                AccessPath = "24-26/В15в"
            };
            var definition25 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.v16-1t",
                IsActive = true,
                AccessPath = "В16-1"
            };
            var definition26 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.v16-1v",
                IsActive = true,
                AccessPath = "24-26/В16-1в"
            };
            var definition27 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.v17t",
                IsActive = true,
                AccessPath = "В17"
            };
            var definition28 = new OpcDaItemDefinition
            {
                ItemId = "Узел2.M12-17.Группа тегов1.v17v",
                IsActive = true,
                AccessPath = "24-26/В17в"
            };
            var definition29 = new OpcDaItemDefinition
            {
                ItemId = "Узел3.V9PVT110.Оперативные параметры.Измеренное значение температуры, °C",
                IsActive = true,
                AccessPath = "В9"
            };
            var definition30 = new OpcDaItemDefinition
            {
                ItemId = "Узел3.V9PVT110.Оперативные параметры.Измеренное значение влажности, %RH",
                IsActive = true,
                AccessPath = "24-26/В9в"
            };
            var definition31 = new OpcDaItemDefinition
            {
                ItemId = "Узел3.V10_1PVT1101.Оперативные параметры.Измеренное значение температуры, °C",
                IsActive = true,
                AccessPath = "В10-1"
            };
            var definition32 = new OpcDaItemDefinition
            {
                ItemId = "Узел3.V10_1PVT1101.Оперативные параметры.Измеренное значение влажности, %RH",
                IsActive = true,
                AccessPath = "24-26/В10-1в"
            };
            var definition33 = new OpcDaItemDefinition
            {
                ItemId = "Узел3.V11PVT1101.Оперативные параметры.Измеренное значение температуры, °C",
                IsActive = true,
                AccessPath = "В11"
            };
            var definition34 = new OpcDaItemDefinition
            {
                ItemId = "Узел3.V11PVT1101.Оперативные параметры.Измеренное значение влажности, %RH",
                IsActive = true,
                AccessPath = "24-26/В11в"
            };

            OpcDaItemDefinition[] definitions = { definition1, definition2, definition3, definition4, definition5, definition6, definition7, definition8, definition9, definition10, definition11, definition12, definition13, definition14,
            definition15, definition16, definition17, definition18, definition19, definition20, definition21, definition22, definition23, definition24, definition25, definition26, definition27, definition28, definition29, definition30,
                definition31, definition32, definition33, definition34};
            OpcDaItemResult[] results = group.AddItems(definitions);

            foreach (OpcDaItemResult result in results)
            {
                if (result.Error.Failed)
                 return result.Error;
            }


            int i = 0;
            int k = 0;
            int l = 0;
            

        for (; l < (fetch.Length/2); l++)
            {
                OpcDaItemValue[] value = group.Read(group.Items, OpcDaDataSource.Device);
                //Console.WriteLine(Convert.ToString(value[i].Item.AccessPath));
                //fetch[i] = Convert.ToString(value[i].Value);
                fetch[i] = Convert.ToString(value[l].Item.AccessPath);
                k = i + 1;
                fetch[k] = Convert.ToString(value[l].Value);
                i = k + 1;
                Thread.Sleep(50);
            }
            return fetch;
           
        }
    }

}

