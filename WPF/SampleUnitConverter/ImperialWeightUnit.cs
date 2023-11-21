using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class ImperialWeightUnit : DistanceUnit {
        private static List<ImperialWeightUnit> units = new List<ImperialWeightUnit> {
            new ImperialWeightUnit{Name="lb",Coefficient=1,},
            new ImperialWeightUnit{Name="oz",Coefficient=1 / 16,},

        };

        public static ICollection<ImperialWeightUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変更します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns>メートル単位</returns>


        public double FromMetricWeightUnit(MetricWeightUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }
}
