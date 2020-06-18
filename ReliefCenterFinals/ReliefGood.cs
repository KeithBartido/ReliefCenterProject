using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS21A_2018_Midterm_Project {
    /* ReliefGood simulates one type of relief good. 
     * An instance of ReliefGood will have its own name, unit of measurement, predetermined release rate, and total number of units available in the supply. 
     * It allows increasing supply by any indicated number. 
     * It allows decreasing supply by the predetermined release rate only. 
   \ */
    class ReliefGood {
        string reliefGoodName;
        string unitOfMeasurement;
        int releaseRate;
        int totalUnits;

        public ReliefGood(String n, int r, String u) {
            /// An instance of ReliefGood must have a name, a unit of measurement, and a release rate.
            /// n - the name of the ReliefGood, e.g. Spam
            /// r - the predetermined release rate of the ReliefGood
            /// u - the unit of measurement of the ReliefGood
            reliefGoodName = n;
            releaseRate = r;
            unitOfMeasurement = u;
        }

        public void AddGoods(int num) {
            /// Increasess the total available units (supply) of the ReliefGood
            /// num - the number of units to be added
            totalUnits += num;
        }

        public string GetName() {
            /// Returns the name of the ReliefGood
            return reliefGoodName = reliefGoodName.ToUpper(); //capitalize for better visibility
        }

        public int GetReleaseRate() {
            /// Returns the predetermined number of units released at one time
            return releaseRate;
        }

        public string GetUnit() {
            /// Returns the unit of measurement of the ReliefGood
            return unitOfMeasurement;
        }

        public int GetUnitsLeft() {
            /// Returns the total available units of ReliefGood
            return totalUnits;
        }

        public void ReleaseGoods() {
            /// Decreases the total avilable units by the corresponding release rate
            totalUnits -= releaseRate;
        }
    }
}
