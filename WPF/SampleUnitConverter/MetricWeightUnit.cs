using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class MetricWeightUnit : DistanceUnit {
        private static List<MetricWeightUnit> units = new List<MetricWeightUnit> {
            new MetricWeightUnit{Name="g",Coefficient=1,},
            new MetricWeightUnit{Name="kg",Coefficient=1 * 1000,},

        };

        public static ICollection<MetricWeightUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変更します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns>メートル単位</returns>


        public double FromImperialWeightUnit(ImperialWeightUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }
}
