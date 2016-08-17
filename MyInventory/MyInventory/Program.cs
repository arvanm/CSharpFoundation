using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace MyInventory
{
    struct ItemData
    {
        public int itemIDNo;
        public string sDescription;
        public double dblPricePerItem;
        public int iQuantityOnHand;
        public double dblOurCostPerItem;
        public double dblValueOfItem;
    }

    class MyInventory
    {
        public static void Main()
        {
            // use an interger to keep track of the count of items in your inventory                                                                       

            int icount = 0;

            // create an array of your ItemData struct

            ItemData[] items = new ItemData[100];

            // use a never ending loop that shows the user what options they can select

            bool breakFlag = false;

            while (!breakFlag)
            {
                // in that loop, show what user can select from the list

                Console.WriteLine("1. Add an item ");

                Console.WriteLine("2. Change an item (by giving its item number)");

                Console.WriteLine("3. Delete an item (by giving its item number)");

                Console.WriteLine("4. List all items in the database");

                Console.WriteLine("5. Quit");

                Console.WriteLine("Please Select an Option:");

                // read the user's input and then create what case it falls       
                Console.WriteLine(); // provide an extra blank line on screen
                string strx = Console.ReadLine();    // read user's input                    
                int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below           
                Console.WriteLine(); // provide an extra blank line on screen

                switch (optx)
                {
                    case 1:  // add an item to the list if this option is selected
                        {
                            items[icount].itemIDNo = icount; // add one to icount

                            Console.WriteLine("Item Name:  ");

                            string strName = Console.ReadLine();

                            items[icount].sDescription = strName;

                            Console.WriteLine("Enter Price of Item: ");

                            string strprice = Console.ReadLine();

                            double dbprice = double.Parse(strprice);

                            items[icount].dblPricePerItem = dbprice;

                            Console.WriteLine("Enter Quantiy Amount: ");

                            string strquantity = Console.ReadLine();

                            int quantity = int.Parse(strquantity);

                            items[icount].iQuantityOnHand = quantity;

                            Console.WriteLine("Enter Cost per Item: ");

                            string strcost = Console.ReadLine();

                            double dbcost = double.Parse(strcost);

                            items[icount].dblOurCostPerItem = dbcost;

                            Console.WriteLine("Enter Value of Item: ");

                            string strvalue = Console.ReadLine();

                            double dbvalue = double.Parse(strvalue);

                            items[icount].dblValueOfItem = dbvalue;

                            icount += 1;

                            Console.WriteLine(); // provide an extra blank line on screen

                            Console.WriteLine(); // provide an extra blank line on screen

                            break;
                        }

                    case 2: //change items in the list if this option is selected
                        {
                            for (var index = 0; index < icount; index++)
                            {
                                Console.WriteLine("{0}. {1}", index + 1, items[index].sDescription);
                            }

                            Console.Write("Please enter an item ID No:");

                            string strchgid = Console.ReadLine();
                            int chgid = int.Parse(strchgid);
                            int value = (chgid - 1);
                            bool fFound = false;

                            for (int index = value; index == value; index++)
                            {
                                //if (items[index].itemIDNo == value)

                                fFound = true;

                                // code to show what has to happen if the item in the list is found

                                Console.WriteLine("Item Name:  ");

                                string strName = Console.ReadLine();

                                items[value].sDescription = strName;



                                Console.WriteLine("Enter Price of Item: ");

                                string strprice = Console.ReadLine();

                                double dbprice = double.Parse(strprice);

                                items[value].dblPricePerItem = dbprice;



                                Console.WriteLine("Enter Quantiy Amount: ");

                                string strquantity = Console.ReadLine();

                                int quantity = int.Parse(strquantity);

                                items[value].iQuantityOnHand = quantity;



                                Console.WriteLine("Enter Cost per Item: ");

                                string strcost = Console.ReadLine();

                                double dbcost = double.Parse(strcost);

                                items[value].dblOurCostPerItem = dbcost;



                                Console.WriteLine("Enter Value of Item: ");

                                string strvalue = Console.ReadLine();

                                double dbvalue = double.Parse(strvalue);

                                items[value].dblValueOfItem = dbvalue;

                                

                            }

                            if (!fFound) // and if not found
                            {
                                Console.WriteLine("Item ID No {0} not found", chgid);
                                Console.WriteLine(); // provide an extra blank line on screen
                            }
                            break;
                        }

                    case 3: //delete items in the list if this option is selected
                        {
                            for (var index = 0; index < icount; index++)
                            {
                                Console.WriteLine("{0}. {1}", index + 1, items[index].sDescription);
                            }

                            Console.Write("Which item to remove (1-{0})", icount);

                            string strnewid = Console.ReadLine();

                            int newid = int.Parse(strnewid);
                            bool fDeleted = false;

                            // delete the item if you found it                            

                            for (var index = newid - 1; index < icount; index++)
                            {
                                fDeleted = true;

                                // Just copy the items from the next index into the current index

                                items[index] = items[index + 1];
                            }

                            // We have one less item

                            if (fDeleted) // hint the user that you deleted the requested item
                            {
                                Console.WriteLine("Item deleted");
                                icount--;
                            }

                            else // if did not find it, hint the user that you did not find it in your list
                            {
                                Console.WriteLine("Item {0} not found", newid);
                            }
                            break;
                        }

                    case 4:  //list all items in current database if this option is selected
                        {
                            Console.WriteLine("ItemID" + "\t" + "Price" + "\t" + "QOH" + "\t" + "Cost" + "\t" + "Value" + "\t" + "Description");
                            Console.WriteLine("------  -----  -----    ----    ------  --------------------");

                            // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it

                            for (int x = 0; x < icount; x++)
                            {
                                Console.WriteLine(" {0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}" + "\t" + "{4}" + "\t" + "{5}", x + 1, items[x].dblPricePerItem, items[x].iQuantityOnHand, items[x].dblOurCostPerItem, items[x].dblValueOfItem, items[x].sDescription);
                            }
                            Console.WriteLine(); // provide an extra blank line on screen
                            break;
                        }

                    case 5: //quit the program if this option is selected
                        {
                            Console.Write("Are you sure that you want to quit(y/n)?");
                            string strresp = Console.ReadLine();

                            string value = (string)(strresp);
                            string strvalue = value.ToUpper();

                            if (strvalue == "Y")
                            {
                                breakFlag = true;        //as long as it is not 5, the process is not breaking           
                            }
                            break;
                        }

                    default:
                        {
                            Console.Write("Invalid Option, try again");
                            Console.WriteLine(); // provide an extra blank line on screen
                            break;
                        }
                }
            }
        }
    }
}

