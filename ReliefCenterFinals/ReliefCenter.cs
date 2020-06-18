using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS21A_2018_Midterm_Project {
    class ReliefCenter {
        int releasedGoods;
        string rcName;

        public List<ReliefGood> relistGoods;

        public ReliefCenter(string n) {
            /* The constructor creates an instance of a ReliefCenter with a name. A new 
                ReliefCenter also has a List<ReliefGood> for ReliefGoods. A new 
                ReliefCenter begins with a total number of packs released of 0.*/
            /// n - the name of the ReliefCenter
            /// release goods = packs
            releasedGoods = 0;
            rcName = n;
            relistGoods = new List<ReliefGood>();
        }

        public string AddNewGood(string n, int r, string u) {
            /*Enables the ReliefCenter to add new kinds of accepted ReliefGoods. 
              Checks if the good is already in their list of accepted goods by calling the FindGood method. */
            string newGood = ""; //string for output window

            if (FindGood(n) == null) {
                relistGoods.Add(new ReliefGood(n, r, u));
                newGood += rcName + " is now accepting " + n + " at " + r + " " + u + "\n--------------------------------------------------------------------------------------------------------------------- \n";
                return newGood;
            }
            else {
                newGood += "Sorry, the Relief Center " + "[" + rcName.ToUpper() + "]" + " already accepts " + n + "\n--------------------------------------------------------------------------------------------------------------------- \n";
                return newGood;
            }
            
        }
                public ReliefGood FindGood(string g) {
            /* Returns the ReliefGood object from the ReliefCenter’s list of accepted 
               ReliefGoods with a name that matches the parameter g
               Returns null if a match is not found. */
                ReliefGood match = null;
                foreach (ReliefGood good in relistGoods) {
                    if (good.GetName().ToLower() == g.ToLower()) {
                    match = good;
                }   
            }
            return match;
        }
            public string GetName() {
                /// Returns the name of the ReliefCenter
                return rcName;
            }

            public int GetPackCount() {
                /// Returns the total number of packs the relief center has released
                return releasedGoods;
            }

            public string PrintInventory() {
            /// Prints the name of each ReliefGood on the list of the Rel98i9i990opo9iefCenter, followed by each one's corresponding available units and unit of measurement
            /// 
            string inventory = "";

            inventory += "===INVENTORY===\n";
            inventory += "Packs Released: " + releasedGoods.ToString() + "\n";
            inventory += "================\n";

                foreach (ReliefGood good in relistGoods) {
                    inventory += good.GetName() + ": " + good.GetUnitsLeft() + " " + good.GetUnit() + "\n";
                }
            inventory += "================\n";
            return inventory;
        }

        public string ReceiveGoods(string good, int num) {
            /// Enables the ReliefCenter to receive donations of a specific ReliefGood.
            /// Checks if the ReliefCenter accepts the ReliefGood being donated by comparing the names of the goods. 
            /// If it is accepted, the number of units donated will be added to the supply of that ReliefGood. 
            /// If it is not accepted, the units will be rejected, and a message is printed to inform the donor that the donation cannot be accepted.
            /// good - the name of the ReliefGood
            /// num - the number of units of the ReliefGood
           
            string receiveGoodsText = "";

            if (FindGood(good) != null) {
                FindGood(good).AddGoods(num);
                receiveGoodsText += "Received " + num + " " + FindGood(good).GetUnit() + " of " + good.ToLower() + ". " + rcName + " thanks you for your donation :)\n--------------------------------------------------------------------------------------------------------------------- \n";
                }
            else {
                receiveGoodsText += "Sorry, the Reliefcenter " +"[" + rcName.ToUpper() + "]" + " doesn't accept " + good + " at the moment. Please try again. \n--------------------------------------------------------------------------------------------------------------------- \n";
            }
            return receiveGoodsText;
            }

            public string ReleasePacks(int num) {

            // if statement to confirm if there is enough supply; [AND] operator; method stops checking when one lacks
            // Units Left - (ReleaseRate * number of packs) [>=0 so it can reach 0]

            string releasePacksText = "";
            bool supplyThresh = true;
            foreach (ReliefGood heldGood in relistGoods) { 
                if (heldGood.GetUnitsLeft() - (heldGood.GetReleaseRate() * num) >= 0)
                {
                    //releasePacksText += "Sorry, " + rcName + "currently does not have enough " + heldGood + " to supply " + num + "packs" ;
                }
                else {
                    supplyThresh = false;
                }
            }
             if (supplyThresh == true) {
                for (int j = 0; j<num; j++) {
                    foreach (ReliefGood goomby in relistGoods) {
                        goomby.ReleaseGoods();
                    }
                    releasedGoods++;
                }

                 releasePacksText += "Packs have successfully been released\n --------------------------------------------------------------------------------------------------------------------- \n";
             }
             else {
                 releasePacksText +=  "Sorry, " + rcName + " currently does not have enough " +  " to supply " + num + " pack\n --------------------------------------------------------------------------------------------------------------------- \n";
             }
            
            return releasePacksText;

        }
    }
    }
    

