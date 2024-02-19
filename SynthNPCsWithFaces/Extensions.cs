using System;
using System.Collections.Generic;
using System.Linq;
using Mutagen.Bethesda;

namespace SynthNPCsWithFaces
{
    public static class Extensions
    {
        public static HashSet<string> StockESMs = new(comparer: StringComparer.InvariantCultureIgnoreCase)
        {
            "Fallout4.esm",
            "DLCRobot.esm",
            "DLCworkshop01.esm",
            "DLCCoast.esm",
            "DLCWorkshop02.esm",
            "DLCWorkshop03.esm",
            "DLCNukaWorld.esm"
        };
        public static IEnumerable<T> NoStockRecords<T>(this IEnumerable<T> records) where T : IMajorRecordGetter
        {
            Console.WriteLine($"{records.First().FormKey.ModKey.Name} {records.First().FormKey.ModKey.FileName} {records.First().FormKey.ModKey.Type}");
            return records
                .Where(r => !StockESMs.Contains(r.FormKey.ModKey.FileName));
        }
    }
}