using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[][][][][[][][][][][][][][[][][][]][][][][][][][][][][][][][]][][][][][][][][][][][[][][][]][][][][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]                                    WELCOME TO STELLA                                       [][]");
            Console.WriteLine("[][]                                       SNACK HUB                                            [][]");
            Console.WriteLine("[][]                             STO.NINO, SAN JUAN , SOUTHERLEYTE                              [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]                                       [][][][][][]                                         [][]");
            Console.WriteLine("[][]                                       []  MENU  []                                         [][]");
            Console.WriteLine("[][]                                       [][][][][][]                                         [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]           \"DRINK'S\"                                           \"FOOD'S\"                     [][]");
            Console.WriteLine("[][]           ---------                                          ---------                     [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]       \"Milktea\"           M    L                   \"Fries\"                    R    S       [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]   1. Cookies & Cream     35 | 45                  1. Sourcream                 35 | 50     [][]");
            Console.WriteLine("[][]   2. Dark Chocolate      35 | 45                  2. Cheese                    35 | 50     [][]");
            Console.WriteLine("[][]   3. Red Velvet          35 | 45                                                           [][]");
            Console.WriteLine("[][]   4. Chocolate           35 | 45                     \"Burger\"                  R    S      [][]");
            Console.WriteLine("[][]   5. Cheese Cake         35 | 45                                                           [][]");
            Console.WriteLine("[][]   6. Hokkaido            35 | 45                  3. Burger                    35 | 50     [][]");
            Console.WriteLine("[][]   7. Winter Melon        35 | 45                  4. Ham and Cheese            35 | 50     [][]");
            Console.WriteLine("[][]                                                   5. Ham and cheese with Egg   35 | 50     [][]");
            Console.WriteLine("[][]       \"Lemonade\"          M    L                                                           [][]");
            Console.WriteLine("[][]                                                      \"Shomai\"                  R    S      [][]");
            Console.WriteLine("[][]   8. Blue Lemonade       35 | 45                                                           [][]");
            Console.WriteLine("[][]   9. Red tea             35 | 45                  6. Chicken                   35 | 50     [][]");
            Console.WriteLine("[][]   10. Fruity Soda         35 | 45                 7.  Pork                     35 | 50     [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]                                                     \"Shopao\"                  R    S       [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]         Add Ons                                   8. Asado                     35 | 50     [][]");
            Console.WriteLine("[][]       Pearl's ---- 10                             9. Bola-Bola                 35 | 50     [][]");
            Console.WriteLine("[][]       Nata ------- 10                                                                      [][]");
            Console.WriteLine("[][]       Sugar ------ 10                                                                      [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][]                                                                                            [][]");
            Console.WriteLine("[][][][][[][][][][][][][][[][][][]][][][][][][][][][][][][][]][][][][][][][][][][][[][][][]][][][][]");
            ForD:
            Console.WriteLine("/Enter 1 for Food/2 for Drinks.");
            Console.Write("1/2:");
            int ford = Convert.ToInt32(Console.ReadLine());
            switch (ford)
            {
                case 1:
                    drinks:
                    Console.WriteLine("Input a number for your order.");
                    Console.Write("Drinks: ");
                    int drink = Convert.ToInt32(Console.ReadLine());
                    switch (drink)
                    {
                        case 1:
                            Console.Write("How many Cookies & Cream Milkteas will you buy?");
                            int ccm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap = Convert.ToInt32(Console.ReadLine());
                            switch (oap)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 2:
                            Console.Write("How many Dark Chocolate Milkteas will you buy?");
                            int dcm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap1 = Convert.ToInt32(Console.ReadLine());
                            switch (oap1)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write("How many Red Velvet Milkteas will you buy?");
                            int rvm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap2 = Convert.ToInt32(Console.ReadLine());
                            switch (oap2)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write("How many Chocolate Milkteas will you buy?");
                            int cm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap3 = Convert.ToInt32(Console.ReadLine());
                            switch (oap3)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write("How many Cheese Cake Milkteas will you buy?");
                            int chcm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap4 = Convert.ToInt32(Console.ReadLine());
                            switch (oap4)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write("How many Hokkaido Milkteas will you buy?");
                            int hm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap5 = Convert.ToInt32(Console.ReadLine());
                            switch (oap5)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write("How many Winter Melon milktes will you buy?");
                            int wmm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap6 = Convert.ToInt32(Console.ReadLine());
                            switch (oap6)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write("How many Blue Lemonades will you buy?");
                            int bl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap7 = Convert.ToInt32(Console.ReadLine());
                            switch (oap7)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write("How many Red Tea Lemonades will you buy?");
                            int rtl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap8 = Convert.ToInt32(Console.ReadLine());
                            switch (oap8)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 10:
                            Console.Write("How many Fruity Soda Lemonades will you buy?");
                            int fsl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What size?");
                            int size9 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed.");
                            int oap9 = Convert.ToInt32(Console.ReadLine());
                            switch (oap9)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        default:
                            Console.Write("Input Invalid. Try again.");
                            goto drinks;
                    }
                    break;
                case 2:
                    foods:
                    Console.WriteLine("Input a number for your order.");
                    Console.Write("Foods: ");
                    int foods = Convert.ToInt32(Console.ReadLine());
                    switch (foods)
                    {
                        case 1:
                            Console.Write("How many orders of Sour Cream Fries will you buy?");
                            int scf = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap10 = Convert.ToInt32(Console.ReadLine());
                            switch (oap10)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 2:
                            Console.Write("How many orders of Cheese Fries will you buy?");
                            int cf = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap11 = Convert.ToInt32(Console.ReadLine());
                            switch (oap11)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write("How many orders of Burger will you buy?");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap12 = Convert.ToInt32(Console.ReadLine());
                            switch (oap12)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write("How many orders of Ham and Cheese Burger will you buy?");
                            int hamb = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap13 = Convert.ToInt32(Console.ReadLine());
                            switch (oap13)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write("How many orders of Ham and Cheese Burger with Egg will you buy?");
                            int hambe = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap14 = Convert.ToInt32(Console.ReadLine());
                            switch (oap14)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write("How many orders of Chicken Shomai will you buy?");
                            int cs = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap15 = Convert.ToInt32(Console.ReadLine());
                            switch (oap15)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write("How many orders of Pork Shomai will you buy?");
                            int ps = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap16 = Convert.ToInt32(Console.ReadLine());
                            switch (oap16)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write("How many orders of Asado Shopao will you buy?");
                            int ash = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap17 = Convert.ToInt32(Console.ReadLine());
                            switch (oap17)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write("How many orders of Bola-Bola Shopao will you buy?");
                            int bbs = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Special or Regular?");
                            int sor8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Press 1 to order again.\nPress 2 to proceed");
                            int oap18 = Convert.ToInt32(Console.ReadLine());
                            switch (oap18)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Try again.");
                            goto foods;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input. Try again.");
                    goto ForD;
            }
            Console.ReadLine();
        }
    }
}
