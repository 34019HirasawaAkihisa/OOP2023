using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    static class ConverterFactory {
        //あらかじめインスタンスを生成し、配列に入れておく
        private static ConverterBase[] _converters = new ConverterBase[] {
            new MeterConverter(),
            new FeetConverter(),
            new InchConverter(),
            new YardConverter(),
        };

        public static ConverterBase GetInstance(String name) {
            return _converters.FirstOrDefault(s => s.IsMyUnit(name));
        }
    }
}
